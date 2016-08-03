using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    class clsAlumno
    {

        public  String nombre { get; set; }
        public int edad { get; set; }
        public int altura { get; set; }
        public int peso { get; set; }

        public clsAlumno(String nombre, int edad, int altura, int peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;
        }

        public clsAlumno()
        {

        }

    }
}
