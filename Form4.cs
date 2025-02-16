using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }
        private void LoadDataFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                var data = lines.Select(line => line.Split(',')).ToList();

                foreach (var row in data)
                {

                    int Przychód = int.Parse(row[0]);
                    int Wydatki = int.Parse(row[1]);
                    int Razem = Przychód - Wydatki;


                    dataGridView1.Rows.Add(Przychód, Wydatki, Razem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas odczytu pliku: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
