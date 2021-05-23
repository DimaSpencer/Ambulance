using Ambulance.Controllers;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance
{
    public partial class PatientsList : Form
    {
        private readonly BrigadeController _brigadeController;
        private readonly PatientController _patientController;

        private readonly CancellationTokenSource cancelTokenSource;
        private readonly CancellationToken token;

        public PatientsList(BrigadeController brigadeController, PatientController patientController)
        {
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;

            _brigadeController = brigadeController;
            _patientController = patientController;

            FormClosed += StopReceive;
            InitializeComponent();

            PatientsGridView.DataSource = _patientController.Patients;
            PatientsGridView.SelectionChanged += PatientsGridView_SelectionChanged;

            PatientsGridView.Columns["CallTime"].Width = 100;
            PatientsGridView.Columns["FullName"].Width = 145;
            PatientsGridView.Columns["Distance"].Width = 60;
            PatientsGridView.Columns["Priority"].Width = 65;

            StartAsync();
        }

        private void PatientsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_patientController.Patients.Count <= 0)
                ButtonSetGroup.Visible = false;
            else
                ButtonSetGroup.Visible = true;
        }

        public async Task StartAsync()
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                    return;

                await Task.Delay(PatientsGenerator.GetRandomTime() * 1000);
                _patientController.NewRandomPacient();
            }
        }

        private void ButtonSetGroup_Click(object sender, EventArgs e)
        {
            var row = PatientsGridView.SelectedRows[0];

            if(row.DataBoundItem is Patient patient)
            {
                if (_brigadeController.ChooseBrigadeForPatient(patient) == true)
                {
                    _patientController.Patients.Remove(patient);
                    PatientsGridView_SelectionChanged(null, null);
                }
            }
        }
        public void StopReceive(object sender, EventArgs e) => cancelTokenSource.Cancel();
    }
}
