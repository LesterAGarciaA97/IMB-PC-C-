using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final_Problema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre;
            Nombre = (textBox1.Text + " " +  textBox2.Text);

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Ingrese todos los datos que se solicitan", "Error");
            }
            else
            {
                MessageBox.Show("Bienvenido " + Nombre);
                groupBox1.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos que se solicitan", "Error");
            }
            else
            {
                MessageBox.Show("Sus horas totales trabajadas son: " + textBox3.Text);
                groupBox3.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos que se solicitan", "Error");
            }
            else
            {
                MessageBox.Show("Sus horas extras totales trabajadas son " + textBox4.Text + " horas");
                groupBox2.Visible = false;
                groupBox4.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                double HorasTrabajadas;
                double HorasExtras;
                HorasTrabajadas = Convert.ToDouble(textBox3.Text);
                HorasExtras = Convert.ToDouble(textBox4.Text);
                textBox5.Text = (Convert.ToString((HorasTrabajadas - HorasExtras) * 39.80));
                
                if (HorasExtras <= 8)
                {
                    textBox6.Text = (Convert.ToString(((HorasExtras * 39.80) * 2)));
                }
                else if (HorasExtras > 8)
                {
                    textBox7.Text = (Convert.ToString((HorasExtras * 39.80) * 3));
                }

                /*double PagoHorasNormales;
                PagoHorasNormales = Convert.ToDouble(textBox5.Text);
                double PagoHorasExtrasDobles;
                PagoHorasExtrasDobles = Convert.ToDouble(textBox6.Text);
                double PagoHorasExtrasTriples;
                PagoHorasExtrasTriples = Convert.ToDouble(textBox7.Text);
                double PagoTotal;
                PagoTotal = (PagoHorasNormales + PagoHorasExtrasDobles + PagoHorasExtrasTriples);
                textBox8.Text = Convert.ToString(PagoTotal);*/
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema");
            MessageBox.Show("Esperamos que haya sido de utilidad");
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema");
            MessageBox.Show("Esperamos que haya sido de utilidad");
            Application.Exit();
        }
    }
}
