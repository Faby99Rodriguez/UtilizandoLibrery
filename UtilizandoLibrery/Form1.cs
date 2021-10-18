using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilizandoLibrery
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
            double valor1 = double.Parse(txbxValMod1.Text);
            double valor2 = double.Parse(txbxValMod2.Text);

           
            label1.Text = operaciones.Residuo.Mostrar(valor1, valor2);

            label2.Text = operaciones.Division.MostrarDiv(valor1, valor2);
        }
    }
}
