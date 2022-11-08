using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBank.Counter31 = comboBox1.Text;
            DataBank.Counter32 = comboBox2.Text;
            DataBank.Counter33 = comboBox3.Text;
            DataBank.Counter34 = comboBox4.Text;
            DataBank.Counter35 = comboBox5.Text;
            DataBank.DCounter31 = Convert.ToInt32(DataBank.Counter31);
            DataBank.DCounter32 = Convert.ToInt32(DataBank.Counter32);
            DataBank.DCounter33 = Convert.ToInt32(DataBank.Counter33);
            DataBank.DCounter34 = Convert.ToInt32(DataBank.Counter34);
            DataBank.DCounter35 = Convert.ToInt32(DataBank.Counter35);
            DataBank.Counter3 = DataBank.DCounter31 + DataBank.DCounter32 + DataBank.DCounter33 + DataBank.DCounter34 + DataBank.DCounter35;
            DataBank.Counter3 = DataBank.Counter3 / 5;

            Question4 forthQuestion = new Question4();
            forthQuestion.Show();

        }

        private void Question3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
