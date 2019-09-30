using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignacion_de_rangos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Cliente 1") && (textBox2.Text == "FPK01100"))
            {
                MessageBox.Show("Bienvenido Cliente 1");
                label2.Dispose();
                textBox1.Dispose();
                textBox2.Dispose();
                button2.Dispose();
                label3.Dispose();
                label4.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox5.Text = ("1 - 1000");
                textBox6.Text = ("1001 - 2000");
                textBox7.Text = ("2001 - 3000");
            }
            else if ((textBox1.Text == "Cliente 2") && (textBox2.Text == "GNC011010"))
            {
                MessageBox.Show("Bienvenido Cliente 2");
                label2.Dispose();
                textBox1.Dispose();
                textBox2.Dispose();
                button2.Dispose();
                label3.Dispose();
                label4.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox5.Text = ("3001 - 4000");
                textBox6.Text = ("4001 - 5000");
                textBox7.Text = ("5001 - 6000");
            }
            else if ((textBox1.Text == "Cliente 3") && (textBox2.Text == "WGM10020"))
            {
                MessageBox.Show("Bienvenido Cliente 3");
                label2.Dispose();
                textBox1.Dispose();
                textBox2.Dispose();
                button2.Dispose();
                label3.Dispose();
                label4.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox5.Text = ("3001 - 4000");
                textBox6.Text = ("4001 - 5000");
                textBox7.Text = ("5001 - 6000");
            }
            else if ((textBox1.Text != "Cliente 1") || (textBox2.Text != "Cliente1"))
            {
                MessageBox.Show("Verificar su información de usuario", "ERROR");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((textBox3.Text == "1") || (textBox3.Text == "1001") || (textBox3.Text == "20001") || (textBox3.Text == "3001") || (textBox3.Text == "4001") || (textBox3.Text == "5001") || (textBox3.Text == "6001")) && ((textBox4.Text == "1000") || (textBox4.Text == "2000") || (textBox4.Text == "3000") || (textBox4.Text == "4000") || (textBox4.Text == "5000") || (textBox4.Text == "6000") || (textBox4.Text == "7000")))
            {
                MessageBox.Show("Rangos ya asignados, intente nuevamente", "ERROR");
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Rango verificado y asignado correctamente");
                MessageBox.Show("Gracias por su nuevo registro");
                textBox8.Text = (textBox3.Text + " - " + textBox4.Text);
                label4.Dispose();
                label5.Dispose();
                label7.Dispose();
                label8.Dispose();
                textBox3.Dispose();
                textBox4.Dispose();
                button1.Dispose();
                label6.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
