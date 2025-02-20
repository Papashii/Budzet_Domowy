namespace Budzet_Domowy
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Przychody = new DataGridViewTextBoxColumn();
            Wydatki = new DataGridViewTextBoxColumn();
            Reszta = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Przychody, Wydatki, Reszta });
            dataGridView1.Location = new Point(112, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(341, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Przychody
            // 
            Przychody.HeaderText = "Przychody";
            Przychody.Name = "Przychody";
            // 
            // Wydatki
            // 
            Wydatki.HeaderText = "Wydatki";
            Wydatki.Name = "Wydatki";
            // 
            // Reszta
            // 
            Reszta.HeaderText = "Reszta";
            Reszta.Name = "Reszta";
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
            // button2
            // 
            button2.Location = new Point(112, 342);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Usuń";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 5;
            button1.Text = "Powróć na stronę główną";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(button1_Click);
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
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
        private Button button2;
        private DataGridViewTextBoxColumn Przychody;
        private DataGridViewTextBoxColumn Wydatki;
        private DataGridViewTextBoxColumn Reszta;
        private Button button1;
    }
}
