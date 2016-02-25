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
    public partial class _2_FormDefinicionVariables : Form
    {
        public _2_FormDefinicionVariables()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int edad = 24;
            String nombre = "johnny";
            MessageBox.Show("La edad de "+nombre + " es de " + edad + " años");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 10;

            MessageBox.Show("La suma es " + (num1 + num2));
        }
    }
}
