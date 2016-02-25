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
    public partial class _5_FormClases : Form
    {
        public _5_FormClases()
        {
            InitializeComponent();
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            clsAlumno alumno = new clsAlumno();

            alumno.setNombre("Johnny");
            alumno.setEdad(24);
            alumno.setAltura(183);
            alumno.setPeso(69);

            MessageBox.Show("Nombre: " + alumno.getNombre() + " Edad: " + alumno.getEdad() +
                            " Altura: " + alumno.getAltura() + " Peso: " + alumno.getPeso());
        }
    }
}
