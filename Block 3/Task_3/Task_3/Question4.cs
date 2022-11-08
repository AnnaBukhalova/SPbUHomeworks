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
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBank.Counter41 = comboBox1.Text;
            DataBank.Counter42 = comboBox2.Text;
            DataBank.Counter43 = comboBox3.Text;
            DataBank.Counter44 = comboBox4.Text;
            DataBank.Counter45 = comboBox5.Text;
            DataBank.DCounter41 = Convert.ToInt32(DataBank.Counter41);
            DataBank.DCounter42 = Convert.ToInt32(DataBank.Counter42);
            DataBank.DCounter43 = Convert.ToInt32(DataBank.Counter43);
            DataBank.DCounter44 = Convert.ToInt32(DataBank.Counter44);
            DataBank.DCounter45 = Convert.ToInt32(DataBank.Counter45);
            DataBank.Counter4 = DataBank.DCounter41 + DataBank.DCounter42 + DataBank.DCounter43 + DataBank.DCounter44 + DataBank.DCounter45;
            DataBank.Counter4 = DataBank.Counter4 / 5;

            Result result = new Result();
            result.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

    

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
