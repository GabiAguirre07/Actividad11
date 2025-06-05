using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        double acumulador = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double prom=acumulador/contador;
            lvresultado.Text=$"El promedio es: {prom:F2}";
            textBox2.Text = $"El promedio es: {prom:F2}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double valor=Convert.ToDouble(textBox1.Text);
            acumulador += valor;
            contador++;
        }

        private void lvresultado_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
