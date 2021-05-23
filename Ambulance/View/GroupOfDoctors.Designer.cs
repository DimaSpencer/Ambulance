
using System.Windows.Forms;

namespace Ambulance
{
    partial class GroupOfDoctors
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
            this.BrigadesGridView = new System.Windows.Forms.DataGridView();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonAddBrigade = new System.Windows.Forms.Button();
            this.ButtonRankUp = new System.Windows.Forms.Button();
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
            this.BrigadesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.BrigadesGridView.ColumnHeadersHeight = 40;
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
            this.BrigadesGridView.Location = new System.Drawing.Point(-2, 93);
            this.BrigadesGridView.MultiSelect = false;
            this.BrigadesGridView.Name = "BrigadesGridView";
            this.BrigadesGridView.ReadOnly = true;
            this.BrigadesGridView.RowHeadersVisible = false;
            this.BrigadesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BrigadesGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.BrigadesGridView.RowTemplate.Height = 32;
            this.BrigadesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BrigadesGridView.Size = new System.Drawing.Size(745, 308);
            this.BrigadesGridView.TabIndex = 0;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonRemove.FlatAppearance.BorderSize = 0;
            this.ButtonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemove.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRemove.Location = new System.Drawing.Point(427, 28);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(148, 48);
            this.ButtonRemove.TabIndex = 1;
            this.ButtonRemove.Text = "Disband a brigade";
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.RemoveBrigade_Click);
            // 
            // ButtonAddBrigade
            // 
            this.ButtonAddBrigade.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonAddBrigade.FlatAppearance.BorderSize = 0;
            this.ButtonAddBrigade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.ButtonAddBrigade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddBrigade.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddBrigade.Location = new System.Drawing.Point(581, 28);
            this.ButtonAddBrigade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddBrigade.Name = "ButtonAddBrigade";
            this.ButtonAddBrigade.Size = new System.Drawing.Size(148, 48);
            this.ButtonAddBrigade.TabIndex = 2;
            this.ButtonAddBrigade.Text = "Hire a brigade ";
            this.ButtonAddBrigade.UseVisualStyleBackColor = false;
            this.ButtonAddBrigade.Click += new System.EventHandler(this.ButtonCreateBrigade_Click);
            // 
            // ButtonRankUp
            // 
            this.ButtonRankUp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonRankUp.FlatAppearance.BorderSize = 0;
            this.ButtonRankUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.ButtonRankUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRankUp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRankUp.Location = new System.Drawing.Point(273, 28);
            this.ButtonRankUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRankUp.Name = "ButtonRankUp";
            this.ButtonRankUp.Size = new System.Drawing.Size(148, 48);
            this.ButtonRankUp.TabIndex = 3;
            this.ButtonRankUp.Text = "Rank up a brigade";
            this.ButtonRankUp.UseVisualStyleBackColor = false;
            this.ButtonRankUp.Click += new System.EventHandler(this.ButtonRankUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "All brigades";
            // 
            // GroupOfDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonRankUp);
            this.Controls.Add(this.ButtonAddBrigade);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.BrigadesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GroupOfDoctors";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.BrigadesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BrigadesGridView;
        private Button ButtonRemove;
        private Button ButtonAddBrigade;
        private Button ButtonRankUp;
        private Label label1;
    }
}