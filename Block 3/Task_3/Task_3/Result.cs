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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = comboBox1.SelectedItem.ToString();
         

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label17.Text = DataBank.Counter3.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Text = DataBank.Counter4.ToString();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            label19.Text = DataBank.Counter2.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label18.Text = DataBank.Counter1.ToString();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            

            if ((DataBank.Counter1 > DataBank.Counter2) && (DataBank.Counter1 > DataBank.Counter3 ) && (DataBank.Counter1 > DataBank.Counter4))
                {
                label21.Text = "Вам стоит это сделать =)";
                }

            if ((DataBank.Counter2 > DataBank.Counter1) && (DataBank.Counter2 > DataBank.Counter3) && (DataBank.Counter2 > DataBank.Counter4))
            {
                label21.Text = "Вам лучше этого не делать =)";
            }

            if ((DataBank.Counter3 > DataBank.Counter1) && (DataBank.Counter3 > DataBank.Counter2) && (DataBank.Counter3 > DataBank.Counter4))
            {
                label21.Text = "Вам не стоит делать этого =(";
            }


            if ((DataBank.Counter4 > DataBank.Counter1) && (DataBank.Counter4 > DataBank.Counter2) && (DataBank.Counter4 > DataBank.Counter3))
            {
                label21.Text = "Вам будет лучше, если вы сделаете это =)";
            }

            
            
            
            
            if ((DataBank.Counter1 == DataBank.Counter2) && (DataBank.Counter1 == DataBank.Counter3) && (DataBank.Counter1 == DataBank.Counter4))
            {
                label21.Text = "Вам стоит изменить важность некоторых пунктов и воспользоваться приложением повторно.";
            }

            if ((DataBank.Counter2 == DataBank.Counter1) && (DataBank.Counter2 == DataBank.Counter3) && (DataBank.Counter2 == DataBank.Counter4))
            {
                label21.Text = "Вам стоит изменить важность некоторых пунктов и воспользоваться приложением повторно.";
            }

            if ((DataBank.Counter3 == DataBank.Counter1) && (DataBank.Counter3 == DataBank.Counter2) && (DataBank.Counter3 == DataBank.Counter4))
            {
                label21.Text = "Вам стоит изменить важность некоторых пунктов и воспользоваться приложением повторно.";
            }


            if ((DataBank.Counter4 == DataBank.Counter1) && (DataBank.Counter4 == DataBank.Counter2) && (DataBank.Counter4 == DataBank.Counter3))
            {
                label21.Text = "Вам стоит изменить важность некоторых пунктов и воспользоваться приложением повторно.";
            }


            if ((DataBank.Counter1 == DataBank.Counter2) && (DataBank.Counter3 == DataBank.Counter4)) 
            {
                label21.Text = "Вам стоит изменить важность некоторых пунктов и воспользоваться приложением повторно.";
            }

            if ((DataBank.Counter1 == DataBank.Counter3) && (DataBank.Counter2 == DataBank.Counter4))
            {
                label21.Text = "Вам стоит изменить важность некоторых пунктов и воспользоваться приложением повторно.";
            }

            if ((DataBank.Counter1 == DataBank.Counter4) && (DataBank.Counter3 == DataBank.Counter2))
            {
                label21.Text = "Вам стоит изменить важность некоторых пунктов и воспользоваться приложением повторно.";
            }





        }
    }
}
