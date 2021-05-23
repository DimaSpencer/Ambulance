using Ambulance.Controllers;
using System;
using System.Windows.Forms;

namespace Ambulance
{
    public partial class FormMenuForm : Form
    {
        private readonly BrigadeController _brigageController;
        private readonly PatientController _patientController;

        public FormMenuForm()
        {
            _brigageController = new BrigadeController();
            _patientController = new PatientController();

            InitializeComponent();

            _brigageController.OnStatisticsChanged += BrigadeStatisticChange;
            _patientController.OnStatisticsChanged += PatientsStatisticChange;

            (HighQBrigadesCured.Text, BrigadesCount.Text) = _brigageController.GetStatistics();
            NumberOfCalls.Text = _patientController.Patients.Count.ToString();

        }

        private void BrigadeStatisticChange(int highQualityBrigadeCount, int brigadesCount)
        {
            HighQBrigadesCured.Text = highQualityBrigadeCount.ToString();
            BrigadesCount.Text = brigadesCount.ToString();
        }

        private void PatientsStatisticChange(int patientsCount)
        {
            NumberOfCalls.Text = patientsCount.ToString();
        }

        private void ButtonOpenGOD_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["GroupOfDoctors"]  == null)
                new GroupOfDoctors(_brigageController).Show();
        }

        private void ButtonOpenPL_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PatientsList"] == null)
                new PatientsList(_brigageController, _patientController).Show();
        }
    }
}
