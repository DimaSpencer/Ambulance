using System;
using System.ComponentModel;

namespace Ambulance.Controllers
{
    public class PatientController
    {
        public Action<int> OnStatisticsChanged;
        public BindingList<Patient> Patients { get; set; }
        public PatientController()
        {
            OnStatisticsChanged = new Action<int>((int a) => { });

            Patients = new BindingList<Patient>()
            {
                PatientsGenerator.Generate(),
                PatientsGenerator.Generate()
            };
        }
        public void NewRandomPacient()
        {
            Patients.Add(PatientsGenerator.Generate());
            Console.Beep();
            OnStatisticsChanged.Invoke(Patients.Count);
        }
    }
}
