namespace Budzet_Domowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                using (Form2 form2 = new Form2())
                {
                    form2.ShowDialog(); 
                }
           
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            using (Form4 form4 = new Form4())
            {
                form4.ShowDialog();
            }

        }
    }
    public class Chleb
    {

    }



}