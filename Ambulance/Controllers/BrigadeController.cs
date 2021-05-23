using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
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
        public Action<int, int> OnChangedCount;
        public Action OnChangedStatusBrigade;

        private readonly FileManager<BindingList<Brigade>> _fileManager;

        public BrigadeController()
        {
            OnChangedCount = new Action<int, int>((int a, int b) => { });
            OnChangedStatusBrigade = new Action(()=> { });

            bool isNewFile = !File.Exists(BRIGADES_FILEPATH);
            _fileManager = new FileManager<BindingList<Brigade>>(BRIGADES_FILEPATH);
            Brigades = _fileManager.LoadObjectFromFile();

            if (isNewFile)
                Add(BaseObjectsInitializer.GetDefaultBrigades().ToArray());
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
            else id = 0;

            LowQualityBrigade brigade = new LowQualityBrigade(++id);
            Add(brigade);
        }

        private void Add(params Brigade[] brigades)
        {
            foreach (var brigade in brigades)
                Brigades.Add(brigade);
            _fileManager.UpdateFile(Brigades);

            OnChangedCount.Invoke(highQualityBrigadeCount, allBrigadesCount);
        }

        public void Remove(Brigade brigade)
        {
            Brigades.Remove(brigade);
            _fileManager.UpdateFile(Brigades);

            OnChangedCount.Invoke(highQualityBrigadeCount, allBrigadesCount);
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

        public async void TakePatient(Brigade brigade, Patient patient)
        {
            string message;
            int waitingTime = Convert.ToInt32(patient.Distance * 100 / brigade.AverageDrivingSpeed);

            brigade.Status = Status.OnTheWay;
            OnChangedStatusBrigade.Invoke();

            message = $"Бригаду №{brigade.Id} було успішно відпрвлено до пацієнта: {patient} приблизний час прибуття {waitingTime} секунд";
            new Thread(() => MessageBox.Show(message, "", MessageBoxButtons.OK)).Start();

            await brigade.GoToPatientAsync(patient);
            _fileManager.UpdateFile(Brigades);

            if(brigade.Specialization == Specializations.HighQualityBrigade)
            {
                message = $"Бригада №{brigade.Id} доставила пацієнта: {patient} до лікарні, вилікує приблизно через {patient.Illness.HealingTime} секунд";
                new Thread(() => MessageBox.Show(message, "", MessageBoxButtons.OK)).Start();
            }

            brigade.Status = Status.HealsThePatient;
            OnChangedStatusBrigade.Invoke();

            await brigade.HealAsync();
            _fileManager.UpdateFile(Brigades);
            OnChangedStatusBrigade.Invoke();

            message = $"Бригада №{brigade.Id} успішно вилікувала пацієнта {patient.FullName} від {patient.Illness.Name} і тепер вже доступна";
            new Thread(() => MessageBox.Show(message, "", MessageBoxButtons.OK)).Start();
        }

        public void RankUp(LowQualityBrigade brigade)
        {
            HighQualityBrigade highQualityBrigade = new HighQualityBrigade()
            {
                Id = brigade.Id,
                Status = brigade.Status,
                Patient = brigade.Patient,
                RecoveredPatients = brigade.RecoveredPatients
            };

            Brigades.Remove(brigade);
            Brigades.Add(highQualityBrigade);

            _fileManager.UpdateFile(Brigades);
            OnChangedCount.Invoke(highQualityBrigadeCount, allBrigadesCount);
        }

        public BindingList<Brigade> GetBrigades(Specializations specialization)
        {
            return (BindingList<Brigade>)Brigades.Where(b =>
            b.Specialization == specialization &&
            b.Status == Status.Free);
        }

        public (string, string) GetStatistics()
        {
            return (highQualityBrigadeCount.ToString(), allBrigadesCount.ToString());
        }
    }
}
