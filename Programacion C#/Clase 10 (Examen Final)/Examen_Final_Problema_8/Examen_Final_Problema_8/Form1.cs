using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final_Problema_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == false) || (radioButton2.Checked == false) || (maskedTextBox1.Text == "") && (maskedTextBox2.Text == "") || (comboBox1.SelectedIndex == -1))
            {
                MessageBox.Show("Ingrese todos los datos que se solicitan", "Error");
            }
            else
            {
                if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
