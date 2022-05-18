using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        int pantalla;
        public Calculadora()
        {
            InitializeComponent();
        }
        
        double num1;
        double num2;
        double resultado;
        
        bool secuencia = true, punto = true;
        string operacion, borrado;
        private void button1_Click(object sender, EventArgs e)
        {

            if (secuencia == true)
            {
               textBox1.Text = "";
                textBox1.Text = "1";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text+ "1";
            }
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "3";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "2";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "5";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "4";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "6";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "7";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "8";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "9";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }


        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;
        }



        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;
        }

        private void producto_Click(object sender, EventArgs e)
        {
            operacion = "*";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            if (operacion == "+")
            {
                resultado = num1 + num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = num1 - num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = num1 * num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = num1 / num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            secuencia = true;
        
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = textBox1.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            textBox1.Text = borrado;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                secuencia = true;
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "0";
                secuencia = true;
            }
        }

       
        


 


    }
}
