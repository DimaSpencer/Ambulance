using System;
using System.Threading;
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
            int travelTime = Convert.ToInt32(patient.Distance * 100 / AverageDrivingSpeed);

            string message = $"Бригаду №{Id} було успішно відпрвлено до пацієнта: {patient} приблизний час прибуття {travelTime * 2} секунд";
            new Thread(() => MessageBox.Show(message, "", MessageBoxButtons.OK)).Start();

            //емуляція подорожі до хворого
            await Task.Delay(travelTime * 1000);

            Patient = patient;

            //емуляція подорожі назад
            await Task.Delay(travelTime * 1000);

            message = $"Бригада №{Id} доставила пацієнта: {Patient} до лікарні, вилікує приблизно через {Patient.Illness.HealingTime} секунд";
            new Thread(() => MessageBox.Show(message, "", MessageBoxButtons.OK)).Start();
        }

        public async override Task HealAsync()
        {
            int time = Patient.Illness.HealingTime;

            //емуляція лікування
            await Task.Delay(time * 1000);
            string message = $"Бригада №{Id} успішно вилікувала пацієнта {Patient.FullName} від {Patient.Illness.Name} і тепер вже доступна";
            new Thread(() => MessageBox.Show(message, "", MessageBoxButtons.OK)).Start();

            Status = Status.Free;
            Patient = null;
            ++RecoveredPatients;
        }
    }
}
