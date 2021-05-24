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
        private readonly FileManager<BindingList<Brigade>> _fileManager;

        public BindingList<Brigade> Brigades { get; set; }
        public Action<int, int> OnChangedCount;
        public Action OnChangedBrigadeStatus;

        public BrigadeController()
        {
            OnChangedCount = new Action<int, int>((int a, int b) => { });
            OnChangedBrigadeStatus = new Action(()=> { });

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
            brigade.Status = Status.OnTheWay;
            OnChangedBrigadeStatus.Invoke();

            await brigade.GoToPatientAsync(patient);
            _fileManager.UpdateFile(Brigades);

            brigade.Status = Status.HealsThePatient;
            OnChangedBrigadeStatus.Invoke();

            await brigade.HealAsync();
            _fileManager.UpdateFile(Brigades);
            OnChangedBrigadeStatus.Invoke();
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
            return new BindingList<Brigade>(Brigades.Where(b =>
            b.Specialization == specialization &&
            b.Status == Status.Free).ToList());
        }

        private int highQualityBrigadeCount { get => Brigades.Where(b => b.Specialization == Specializations.HighQualityBrigade).Count(); }
        private int allBrigadesCount { get => Brigades.Count; }
        public (string, string) GetStatistics()
        {
            return (highQualityBrigadeCount.ToString(), allBrigadesCount.ToString());
        }
    }
}
