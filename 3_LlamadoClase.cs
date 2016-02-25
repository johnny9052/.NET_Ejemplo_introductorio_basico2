using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoDotNet
{
    public partial class _3_LlamadoClase : Form
    {
        public _3_LlamadoClase()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(txtNumero1.Text);
            int num2 = Convert.ToInt32(txtNumero2.Text);

            clsOperaciones operacion = new clsOperaciones();

            MessageBox.Show("El resultado de la suma es "+operacion.sumar(num1,num2));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
