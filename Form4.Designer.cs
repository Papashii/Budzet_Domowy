﻿namespace Budzet_Domowy
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            Wydatki = new DataGridViewTextBoxColumn();
            Przychody = new DataGridViewTextBoxColumn();
            Reszta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Wydatki, Przychody, Reszta });
            dataGridView1.Location = new Point(112, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(341, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(79, 59);
            label1.Name = "label1";
            label1.Size = new Size(468, 37);
            label1.TabIndex = 1;
            label1.Text = "Tabela ogólna wydatków/przychodów";
            label1.Click += label1_Click;
          
            // 
            // Wydatki
            // 
            Wydatki.HeaderText = "Wydatki";
            Wydatki.Name = "Wydatki";
            // 
            // Przychody
            // 
            Przychody.HeaderText = "Przychody";
            Przychody.Name = "Przychody";
            // 
            // Reszta
            // 
            Reszta.HeaderText = "Reszta";
            Reszta.Name = "Reszta";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Raport budżetu domowego";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Wydatki;
        private DataGridViewTextBoxColumn Przychody;
        private DataGridViewTextBoxColumn Reszta;
    }
}