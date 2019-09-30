using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final_Problema_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text == "") || (maskedTextBox2.Text == ""))
            {
                MessageBox.Show("Ingrese los datos que se solicitan para continuar", "Error");
            }
            else
            {
                int NumPrincipal;
                NumPrincipal = Convert.ToInt32(maskedTextBox1.Text);
                int NumFinal;
                NumFinal = Convert.ToInt32(maskedTextBox2.Text);
                
                for (int i = 0; i <= NumFinal; i++)
                {
                    listBox1.Items.Add(NumPrincipal + " x " + i + " = " + (NumPrincipal * i)); 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestro sistema");
            Application.Restart();
        }
    }
}
