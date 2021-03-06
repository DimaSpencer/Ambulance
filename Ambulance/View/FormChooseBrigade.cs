using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ambulance
{
    public partial class FormChooseBrigade : Form
    {
        public FormChooseBrigade(BindingList<Brigade> brigades)
        {
            InitializeComponent();

            BrigadesGridView.SelectionChanged += GridSelectionChanged;

            BrigadesGridView.DataSource = brigades;
            BrigadesGridView.Columns["Patient"].Visible = false;
            BrigadesGridView.Columns["AverageDrivingSpeed"].Visible = false;
            BrigadesGridView.Columns["RecoveredPatients"].Width = 150;
            BrigadesGridView.Columns["Specialization"].Width = 150;
        }

        private void GridSelectionChanged(object sender, EventArgs e)
        {
            if (BrigadesGridView.SelectedCells.Count > 0)
                ButtonChoice.Visible = true;
            else
                ButtonChoice.Visible = false;
        }

        public Brigade GetSelectedBrigade()
        {
            var row = BrigadesGridView.SelectedRows[0];
            if (row.DataBoundItem is Brigade brigade)
                return brigade;
            else
                throw new InvalidCastException($"{row.DataBoundItem.GetType()} is'nt a Brigade");
        }

    }
}
