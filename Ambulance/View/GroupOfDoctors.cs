using Ambulance.Controllers;
using System;
using System.Windows.Forms;

namespace Ambulance
{
    public partial class GroupOfDoctors : Form
    {
        private readonly BrigadeController _brigageController;
        
        public GroupOfDoctors(BrigadeController brigageController)
        {
            _brigageController = brigageController;

            InitializeComponent();
            BrigadesGridView.SelectionChanged += GridSelectionChanged;
            UpdateGrid(null, null);

            this.MouseEnter += UpdateGrid;
        }

        private void UpdateGrid(object sender, EventArgs e)
        {
            BrigadesGridView.DataSource = null;
            BrigadesGridView.DataSource = _brigageController.Brigades;

            BrigadesGridView.Columns["Id"].Width = 40;
            BrigadesGridView.Columns["Status"].Width = 75;
            BrigadesGridView.Columns["Specialization"].Width = 140;
            BrigadesGridView.Columns["Patient"].Width = 172;
            BrigadesGridView.Columns["RecoveredPatients"].Width = 130;
            BrigadesGridView.Columns["AverageDrivingSpeed"].Visible = false;
        }

        private void GridSelectionChanged(object sender, EventArgs e)
        {
            if (BrigadesGridView.SelectedCells.Count > 0)
            {
                ButtonRemove.Visible = true;
                ButtonRankUp.Visible = true;
            }
            else
            {
                if(_brigageController.Brigades.Count <= 0)
                {
                    ButtonRemove.Visible = false;
                    ButtonRankUp.Visible = false;
                    if (MessageBox.Show($"Бригад немає, бажаєте створити нову бригаду?", "Увага",
                        MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        _brigageController.CreateNewBrigade();
                    }
                }
            }
        }

        private void RemoveBrigade_Click(object sender, EventArgs e)
        {
            var row = BrigadesGridView.SelectedRows[0];
            if (row.DataBoundItem is Brigade brigade)
            {
                if (MessageBox.Show($"Ви дійсно хочете розформувати бригаду №{brigade.Id}", "Видалення бригади", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _brigageController.Remove(brigade);
                    MessageBox.Show($"Бригаду №{ brigade.Id} розформовано", "Видалення бригади", MessageBoxButtons.OK);
                }
            }
        }

        private void ButtonCreateBrigade_Click(object sender, EventArgs e)
        {
            _brigageController.CreateNewBrigade();
        }

        private void ButtonRankUp_Click(object sender, EventArgs e)
        {
            var row = BrigadesGridView.SelectedRows[0];
            if (row.DataBoundItem is Brigade brigade)
                _brigageController.RankUp(brigade);
        }
    }
}
