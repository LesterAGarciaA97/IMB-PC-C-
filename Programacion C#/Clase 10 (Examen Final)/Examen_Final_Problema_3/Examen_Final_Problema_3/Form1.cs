using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final_Problema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (comboBox1.SelectedIndex == -1))
            {
                MessageBox.Show("Ingrese todos los datos que se solicitan", "Error");
            }
            else
            {
                MessageBox.Show("Sus datos están siendo procesados", "Espere");
            }

            int AñosEnLaEmpresa;
            AñosEnLaEmpresa = comboBox1.SelectedIndex;

            switch (AñosEnLaEmpresa)
            {
                case 0:
                    textBox2.Text = ("5% de salario");
                    break;
                case 1:
                    textBox2.Text = ("7% de salario");
                    break;
                case 2:
                    textBox2.Text = ("10% de salario");
                    break;
                case 3:
                    textBox2.Text = ("15% de salario");
                    break;
                case 4:
                    textBox2.Text = ("20% de salario");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gradcias por utilizar nuestro sistema");
            Application.Restart();
        }
    }
}
