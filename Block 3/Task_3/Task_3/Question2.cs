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
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void Question2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBank.Counter21 = comboBox1.Text;
            DataBank.Counter22 = comboBox2.Text;
            DataBank.Counter23 = comboBox3.Text;
            DataBank.Counter24 = comboBox4.Text;
            DataBank.Counter25 = comboBox5.Text;
            DataBank.DCounter21 = Convert.ToInt32(DataBank.Counter21);
            DataBank.DCounter22 = Convert.ToInt32(DataBank.Counter22);
            DataBank.DCounter23 = Convert.ToInt32(DataBank.Counter23);
            DataBank.DCounter24 = Convert.ToInt32(DataBank.Counter24);
            DataBank.DCounter25 = Convert.ToInt32(DataBank.Counter25);
            DataBank.Counter2 = DataBank.DCounter21 + DataBank.DCounter22 + DataBank.DCounter23 + DataBank.DCounter24 + DataBank.DCounter25;
            DataBank.Counter2 = DataBank.Counter2 / 5;

            Question3 thirdQuestion = new Question3();
            thirdQuestion.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
