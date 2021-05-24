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
            BrigadesGridView.DataSource = _brigageController.Brigades;
            _brigageController.OnChangedBrigadeStatus += UpdateGrid;
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            BrigadesGridView.DataSource = null;
            BrigadesGridView.DataSource = _brigageController.Brigades;

            BrigadesGridView.Columns["Id"].Width = 40;
            BrigadesGridView.Columns["Status"].Width = 75;
            BrigadesGridView.Columns["Specialization"].Width = 140;
            BrigadesGridView.Columns["Patient"].Width = 172;
            BrigadesGridView.Columns["RecoveredPatients"].Width = 130;
            BrigadesGridView.Columns["AverageDrivingSpeed"].Visible = false;

            if (_brigageController.Brigades.Count <= 0)
            {
                ButtonRemove.Visible = false;
                ButtonRankUp.Visible = false;
                if (MessageBox.Show($"Бригад немає, бажаєте створити нову бригаду?", "Увага", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _brigageController.HireBrigade();
                    MessageBox.Show($"Нову бригаду створено", "Увага!", MessageBoxButtons.OK);
                }
            }
        }

        private void GridSelectionChanged(object sender, EventArgs e)
        {
            if (BrigadesGridView.SelectedCells.Count > 0)
            {
                ButtonRemove.Visible = true;
                ButtonRankUp.Visible = true;
            }
            if (_brigageController.Brigades.Count <= 0)
            {
                ButtonRemove.Visible = false;
                ButtonRankUp.Visible = false;
            }
        }

        private void RemoveBrigade_Click(object sender, EventArgs e)
        {
            var selectedBrigade = TryToGetSelectedBrigade();

            if (MessageBox.Show($"Ви дійсно хочете розформувати бригаду №{selectedBrigade.Id}", "Видалення бригади", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _brigageController.Remove(selectedBrigade);
                MessageBox.Show($"Бригаду №{ selectedBrigade.Id} розформовано", "Видалення бригади", MessageBoxButtons.OK);
            }
        }

        private void ButtonCreateBrigade_Click(object sender, EventArgs e)
        {
            _brigageController.HireBrigade();
            MessageBox.Show($"Нову бригаду створено", "Увага!", MessageBoxButtons.OK);
        }

        private void ButtonRankUp_Click(object sender, EventArgs e)
        {
            var selectedBrigade = TryToGetSelectedBrigade();

            if (selectedBrigade.Specialization == Specializations.Brigade && selectedBrigade.Status == Status.Free)
            {
                _brigageController.RankUp((LowQualityBrigade)selectedBrigade);
                MessageBox.Show($"Бригада була підвищена", "", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show($"Бригада вже максильного рангу", "Помилка!", MessageBoxButtons.OK);
        }

        private Brigade TryToGetSelectedBrigade()
        {
            var row = BrigadesGridView.SelectedRows[0];
            if (row.DataBoundItem is Brigade brigade)
                return brigade;
            else throw new InvalidCastException($"{row.DataBoundItem.GetType()} is'nt a Brigade");
        }
    }
}
