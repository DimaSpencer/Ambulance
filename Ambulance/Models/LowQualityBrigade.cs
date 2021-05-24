using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance
{
    [Serializable]
    public class LowQualityBrigade : Brigade
    {
        public override Specializations Specialization { get; set; } = Specializations.Brigade;
        public override double AverageDrivingSpeed { get; set; } = 70;

        public LowQualityBrigade() : base() { }
        public LowQualityBrigade(int id) : base(id) { }

        public async override Task GoToPatientAsync(Patient patient)
        {
            int travelTime = Convert.ToInt32(patient.Distance * 100 / AverageDrivingSpeed);
            int waitingTime = travelTime * 2 + patient.Illness.HealingTime;

            string message = $"Бригаду №{Id} було успішно відпрвлено до пацієнта: {patient} приблизний час вилікування і прибуття {waitingTime} секунд";
            new Thread(() => MessageBox.Show(message, "", MessageBoxButtons.OK)).Start();

            //емуляція подорожі до хворого
            Patient = patient;
            await Task.Delay(travelTime * 1000);
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
