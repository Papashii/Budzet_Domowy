using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Budzet_Domowy
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadDataFromFile("dane.txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadDataFromFile("dane.txt");
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                var data = lines.Select(line => line.Split(',')).ToList();

                foreach (var row in data)
                {
                    int przychód = int.Parse(row[0]);
                    int wydatek = int.Parse(row[1]);
                    int reszta = przychód - wydatek;

                    dataGridView1.Rows.Add(przychód, wydatek, reszta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas odczytu pliku: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            
            SaveDataToFile("dane.txt");

          
            MessageBox.Show("Rekordy zostały pomyślnie usunięte.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void SaveDataToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var wydatek = row.Cells["Wydatki"].Value?.ToString();
                            var przychód = row.Cells["Przychody"].Value?.ToString();
                            var reszta = row.Cells["Reszta"].Value?.ToString();
                            writer.WriteLine($"{przychód},{wydatek},{reszta}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisu pliku: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
