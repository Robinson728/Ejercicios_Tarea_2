using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Factorial_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_numero.Text);
            int resultado = 0;

            resultado = Factorial(num);

            txt_resultado.Text = resultado.ToString();
        }

        private int Factorial(int numero)
        {
            int total = 0, sumatoria = 0;
            for(int i = numero-1; i>0; i--)
            {
                numero *= i;
            }
            return numero;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_numero.Clear();
            txt_resultado.Clear();
        }
    }
}
