using System;
using System.Windows.Forms;

namespace tpmodul12_103022300099
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ngga digunakan 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public static string CariTandaBilangan(int angka)
        {
            if (angka < 0)
                return "Negatif";
            else if (angka > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(textBox1.Text, out input))
            {
                string hasil = CariTandaBilangan(input);
                label1.Text = $"Output: {hasil}\nPangkat dua: {input * input}";
            }
            else
            {
                label1.Text = "Input tidak valid";
            }
        }
    }
}

