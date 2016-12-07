using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1
{
    public partial class HT1 : Form
    {
        public HT1()
        {
            InitializeComponent();
        }

        private void HT1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {

            if (entradaa.Text != "" && entradab.Text != "" && entradac.Text != "" && entradad.Text != "")
            {
                try
                {
                    double variable_a = double.Parse(entradaa.Text);
                    double variable_b = double.Parse(entradab.Text);
                    double variable_c = double.Parse(entradac.Text);
                    double variable_d = double.Parse(entradad.Text);

                    double operacion1 = variable_a + variable_b;
                    double operacion2 = variable_c + variable_d;
                    double operacion3 = operacion1 * operacion1;
                    double total = operacion3 / operacion2;

                    respuesta.Text = total.ToString();
                } catch(Exception){
                    MessageBox.Show("Ingrese únicamente números");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (entradaa.Text != "" && entradab.Text != "" && entradac.Text != "" && entradad.Text != "")
            {
                try
                {
                    double variable_a = double.Parse(entradaa.Text);
                    double variable_b = double.Parse(entradab.Text);
                    double variable_c = double.Parse(entradac.Text);
                    double variable_d = double.Parse(entradad.Text);

                    double operacion1 = variable_a * variable_d;
                    double operacion2 = variable_b + variable_c;
                    double total = operacion1 - operacion2;
                    
                    respuesta.Text = total.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese únicamente números");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (entradaa.Text != "" && entradab.Text != "" && entradac.Text != "" && entradad.Text != "")
            {
                try
                {
                    double variable_a = double.Parse(entradaa.Text);
                    double variable_b = double.Parse(entradab.Text);
                    double variable_c = double.Parse(entradac.Text);
                    double variable_d = double.Parse(entradad.Text);

                    double operacion1 = variable_a + variable_b - variable_c;
                    double total = operacion1 * variable_d;
                    
                    respuesta.Text = total.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese únicamente números");
                }

            }
        }
    }
}
