using System;
using System.IO;
using System.Windows.Forms;

namespace Budzet_Domowy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string filePath = "dane.txt";

            // Dane z kontrolek
            if (!decimal.TryParse(textBox1.Text, out decimal income) || income <= 0 ||
                !decimal.TryParse(textBox2.Text, out decimal expense) || expense <= 0)
            {
                MessageBox.Show("Podałeś że masz więcej wydatków niż przychodu!!! Wprowadź odpowiednie dane");
                return;
            }

            if (expense > income)
            {
                MessageBox.Show("Wydatki nie mogą być większe niż przychód.");
                return;
            }

            string dataToSave = $"{income},{expense}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(dataToSave);
            }


            MessageBox.Show("Pomyślnie wprowadzono dane");


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
