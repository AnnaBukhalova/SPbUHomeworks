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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBank.Counter11 = comboBox1.Text;
            DataBank.Counter12 = comboBox2.Text;
            DataBank.Counter13 = comboBox3.Text;
            DataBank.Counter14 = comboBox4.Text;
            DataBank.Counter15 = comboBox5.Text;
            DataBank.DCounter11 = Convert.ToInt32(DataBank.Counter11);
            DataBank.DCounter12 = Convert.ToInt32(DataBank.Counter12);
            DataBank.DCounter13 = Convert.ToInt32(DataBank.Counter13);
            DataBank.DCounter14 = Convert.ToInt32(DataBank.Counter14);
            DataBank.DCounter15 = Convert.ToInt32(DataBank.Counter15);
            DataBank.Counter1 = DataBank.DCounter11 + DataBank.DCounter12 + DataBank.DCounter13 + DataBank.DCounter14 + DataBank.DCounter15;
            DataBank.Counter1 = DataBank.Counter1 / 5;

            Question2 secondQuestion = new Question2();
            secondQuestion.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Question1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
