using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance
{
    [Serializable]
    public class HighQualityBrigade : Brigade //додаємо спеціалізацію бригади
    {
        public override Specializations Specialization { get; set; } = Specializations.HighQualityBrigade;
        public override double AverageDrivingSpeed { get; set; } = 100;

        public HighQualityBrigade() : base() { }
        public HighQualityBrigade(int id) : base(id) { }

        public async override Task GoToPatientAsync(Patient patient)
        {
            Status = Status.OnTheWay;
            int travelTime = Convert.ToInt32(patient.Distance * 100 / AverageDrivingSpeed); 

            //емуляція подорожі до хворого
            Patient = patient;
            await Task.Delay(travelTime * 1000);

            //емуляція подорожі назад
            await Task.Delay(travelTime * 1000);
            MessageBox.Show($"Бригада №{Id} доставила пацієнта: {patient} до лікарні, вилікує приблизно через {patient.Illness.HealingTime} секунд");
        }

        public async override Task HealAsync()
        {
            Status = Status.HealsThePatient;
            int time = Patient.Illness.HealingTime;

            //емуляція лікування
            await Task.Delay(time * 1000);

            Status = Status.Free;
            MessageBox.Show($"Бригада №{Id} успішно вилікувала пацієнта {Patient.FullName} від {Patient.Illness.Name} і тепер вже доступна");
            Patient = null;
            ++RecoveredPatients;
        }
    }
}
