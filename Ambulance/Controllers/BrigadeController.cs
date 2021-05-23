using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace Ambulance.Controllers
{
    public class BrigadeController
    {
        private readonly string BRIGADES_FILEPATH = "brigades.xml";

        private int highQualityBrigadeCount { get => Brigades.Where(b => b.Specialization == Specializations.HighQualityBrigade).Count(); }
        private int allBrigadesCount { get => Brigades.Count; }

        public BindingList<Brigade> Brigades { get; set; }
        public Action<int, int> OnStatisticsChanged;

        private readonly FileManager<BindingList<Brigade>> _fileManager;

        public BrigadeController()
        {
            OnStatisticsChanged = new Action<int, int>((int a, int b) => { });

            _fileManager = new FileManager<BindingList<Brigade>>(BRIGADES_FILEPATH);
            Brigades = _fileManager.LoadObjectFromFile();

            if (Brigades.Count <= 0)
                InitializeDefaultBrigades();
        }

        public void CreateNewBrigade()
        {
            int id;
            if (Brigades.Count > 0)
            {
                int lastNumber = Brigades.Count - 1;
                int lastId = Brigades[lastNumber].Id;
                id = ++lastId;
            }
            else
                id = 1;

            LowQualityBrigade brigade = new LowQualityBrigade(++id);
            Add(brigade);
            MessageBox.Show($"Нову бригаду №{brigade.Id} створено", "Увага!", MessageBoxButtons.OK);
        }

        private void Add(params Brigade[] brigades)
        {
            foreach (var brigade in brigades)
                Brigades.Add(brigade);
            _fileManager.UpdateFile(Brigades);

            OnStatisticsChanged.Invoke(highQualityBrigadeCount, allBrigadesCount);
        }

        public void Remove(Brigade brigade)
        {
            Brigades.Remove(brigade);
            _fileManager.UpdateFile(Brigades);

            OnStatisticsChanged.Invoke(highQualityBrigadeCount, allBrigadesCount);
        }

        public bool ChooseBrigadeForPatient(Patient patient)
        {
            Specializations specialization;

            if (patient.Illness.Priority == Priorities.High)
                specialization = Specializations.HighQualityBrigade;
            else
                specialization = Specializations.Brigade;

            BindingList<Brigade> brigades = GetBrigades(specialization);

            if (brigades.Count <= 0)
            {
                MessageBox.Show($"Наразі вільних бригад потрібної спеціалізації немає", "Увага", MessageBoxButtons.OK);
                return false;
            }

            FormChooseBrigade formChoiceBrigade = new FormChooseBrigade(brigades);
            if (formChoiceBrigade.ShowDialog() == DialogResult.OK)
            {
                Brigade brigade = formChoiceBrigade.GetSelectedBrigade();

                Task.Run(() => TakePatient(brigade, patient));

                return true;
            }
            else
                return false;
        }

        public void RankUp(Brigade brigade)
        {
            if(brigade.Specialization == Specializations.Brigade && brigade.Status == Status.Free)
            {
                HighQualityBrigade highQualityBrigade = new HighQualityBrigade() {
                    Id = brigade.Id,
                    Status = brigade.Status,
                    Patient = brigade.Patient,
                    RecoveredPatients = brigade.RecoveredPatients
                };

                Brigades.Remove(brigade);
                Brigades.Add(highQualityBrigade);

                _fileManager.UpdateFile(Brigades);
                MessageBox.Show($"Бригада була підвищена", "", MessageBoxButtons.OK);
                OnStatisticsChanged.Invoke(highQualityBrigadeCount, allBrigadesCount);
            }
            else
                MessageBox.Show($"Бригада вже максильного рангу", "Помилка!", MessageBoxButtons.OK);
        }

        public async void TakePatient(Brigade brigade, Patient patient)
        {
            int waitingTime = Convert.ToInt32(patient.Distance * 100 / brigade.AverageDrivingSpeed);
            MessageBox.Show($"Бригаду №{brigade.Id} було успішно відпрвлено до пацієнта: {patient} приблизний час прибуття {waitingTime} секунд","", MessageBoxButtons.OK);

            await brigade.GoToPatientAsync(patient);
            _fileManager.UpdateFile(Brigades);

            await brigade.HealAsync();
            _fileManager.UpdateFile(Brigades);
        }

        public BindingList<Brigade> GetBrigades(Specializations specialization)
        {
            BindingList<Brigade> brigades = new BindingList<Brigade>(
                Brigades.Where(
                b => b.Specialization == specialization &&
                     b.Status == Status.Free).ToList());

            return brigades;
        }

        private void InitializeDefaultBrigades()
        {
            Brigade[] brigades = new Brigade[]
            {
                new HighQualityBrigade { Id = 1, Status = Status.Free },
                new HighQualityBrigade { Id = 2, Status = Status.Free },
                new HighQualityBrigade { Id = 3, Status = Status.Free },

                new LowQualityBrigade { Id = 4, Status = Status.Free },
                new LowQualityBrigade { Id = 5, Status = Status.Free },
                new LowQualityBrigade { Id = 6, Status = Status.Free }
            };
            Add(brigades);
        }

        public (string, string) GetStatistics()
        {
            return (highQualityBrigadeCount.ToString(), allBrigadesCount.ToString());
        }
    }
}
