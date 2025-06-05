using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        double acumulador1 = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             double valor=Convert.ToDouble(textBox1.Text);
            
            acumulador1 += valor;
            contador++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double prom = acumulador1 / contador;
            lvresultado.Text = $"El promedio es: {prom:F2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
