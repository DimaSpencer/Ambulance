
using System.Windows.Forms;

namespace Ambulance
{
    partial class PatientsList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PatientsGridView = new System.Windows.Forms.DataGridView();
            this.ButtonSetGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientsGridView
            // 
            this.PatientsGridView.AllowUserToAddRows = false;
            this.PatientsGridView.AllowUserToDeleteRows = false;
            this.PatientsGridView.AllowUserToResizeColumns = false;
            this.PatientsGridView.AllowUserToResizeRows = false;
            this.PatientsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsGridView.ColumnHeadersHeight = 44;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PatientsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PatientsGridView.Location = new System.Drawing.Point(-3, 67);
            this.PatientsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientsGridView.MultiSelect = false;
            this.PatientsGridView.Name = "PatientsGridView";
            this.PatientsGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PatientsGridView.RowHeadersVisible = false;
            this.PatientsGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PatientsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientsGridView.RowTemplate.Height = 35;
            this.PatientsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsGridView.Size = new System.Drawing.Size(699, 304);
            this.PatientsGridView.TabIndex = 0;
            // 
            // ButtonSetGroup
            // 
            this.ButtonSetGroup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonSetGroup.FlatAppearance.BorderSize = 0;
            this.ButtonSetGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.ButtonSetGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSetGroup.Location = new System.Drawing.Point(511, 11);
            this.ButtonSetGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSetGroup.Name = "ButtonSetGroup";
            this.ButtonSetGroup.Size = new System.Drawing.Size(173, 44);
            this.ButtonSetGroup.TabIndex = 1;
            this.ButtonSetGroup.Text = "Set Brigade";
            this.ButtonSetGroup.UseVisualStyleBackColor = false;
            this.ButtonSetGroup.Click += new System.EventHandler(this.ButtonSetGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of receipts";
            // 
            // PatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSetGroup);
            this.Controls.Add(this.PatientsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PatientsList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsGridView;
        private System.Windows.Forms.Button ButtonSetGroup;
        private Label label1;
    }
}

