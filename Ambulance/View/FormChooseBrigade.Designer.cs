
using System.Windows.Forms;

namespace Ambulance
{
    partial class FormChooseBrigade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BrigadesGridView = new System.Windows.Forms.DataGridView();
            this.ButtonChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BrigadesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BrigadesGridView
            // 
            this.BrigadesGridView.AllowUserToAddRows = false;
            this.BrigadesGridView.AllowUserToDeleteRows = false;
            this.BrigadesGridView.AllowUserToResizeColumns = false;
            this.BrigadesGridView.AllowUserToResizeRows = false;
            this.BrigadesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrigadesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrigadesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BrigadesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BrigadesGridView.ColumnHeadersHeight = 29;
            this.BrigadesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BrigadesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BrigadesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BrigadesGridView.Location = new System.Drawing.Point(-1, 58);
            this.BrigadesGridView.MultiSelect = false;
            this.BrigadesGridView.Name = "BrigadesGridView";
            this.BrigadesGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BrigadesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BrigadesGridView.RowHeadersVisible = false;
            this.BrigadesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BrigadesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BrigadesGridView.RowTemplate.Height = 35;
            this.BrigadesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BrigadesGridView.Size = new System.Drawing.Size(477, 319);
            this.BrigadesGridView.TabIndex = 0;
            // 
            // ButtonChoice
            // 
            this.ButtonChoice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonChoice.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonChoice.FlatAppearance.BorderSize = 0;
            this.ButtonChoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.ButtonChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChoice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChoice.Location = new System.Drawing.Point(308, 5);
            this.ButtonChoice.Name = "ButtonChoice";
            this.ButtonChoice.Size = new System.Drawing.Size(151, 47);
            this.ButtonChoice.TabIndex = 1;
            this.ButtonChoice.Text = "To appoint";
            this.ButtonChoice.UseVisualStyleBackColor = false;
            this.ButtonChoice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a free brigade:";
            // 
            // FormChooseBrigade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonChoice);
            this.Controls.Add(this.BrigadesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormChooseBrigade";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.BrigadesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BrigadesGridView;
        private Button ButtonChoice;
        private Label label1;
    }
}