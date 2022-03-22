using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear(); // la caja tiene que estar vacia para que no vaya a haber errores
            int residuo = 0;
            string resultado = " ";
            int numero = int.Parse(this.textBox1.Text); // almacenamos el numero a convertir en una variable de tipo entero
            do
            {
                residuo = numero % 2;
                numero = numero / 2;
                resultado = residuo + resultado;
            } while (numero != 0);
            this.textBox2.Text = resultado;


        }

        bool EsBinario(int numero)
        {
            int digito = 0;
            bool sw = true;
            while(numero > 0)
            {
                digito = numero % 10;
                numero = numero / 10;
                if (digito > 1)
                {
                    sw = false;
                    numero = 0;
                }

            }

            return sw;
        }

        private void binarioADecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(this.textBox3.Text);
            int digito;
            int secuencia = 1;
            int Ndecimal = 0;
            if (EsBinario(numero))
            {
                while (numero > 0)
                {
                    digito = numero % 10;
                    numero = numero / 10;
                    Ndecimal = Ndecimal + (digito * secuencia);
                    secuencia = secuencia * 2;
                }

                //MessageBox.Show(Ndecimal.ToString() + " es en decimal ");
                Resultado.Items.Add(Ndecimal.ToString());
            }
            else
            {
                //   MessageBox.Show(" Su numero no es valido ");
                Resultado.Items.Add(" Su numero no es binario ");
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Resultado.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
    }
