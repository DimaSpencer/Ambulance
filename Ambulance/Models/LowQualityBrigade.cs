using System;
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
            //емуляція подорожі до хворого
            Patient = patient;
            await Task.Delay(travelTime * 1000);
        }

        public async override Task HealAsync()
        {
            int time = Patient.Illness.HealingTime;

            //емуляція лікування
            await Task.Delay(time * 1000);

            Status = Status.Free;
            Patient = null;
            ++RecoveredPatients;
        }
    }
}
