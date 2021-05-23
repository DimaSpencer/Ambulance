using System;
using System.Threading.Tasks;

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

            //емуляція подорожі до хворого
            await Task.Delay(travelTime * 1000);

            Patient = patient;

            //емуляція подорожі назад
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
