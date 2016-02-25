using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    class clsAlumno
    {

         private String nombre;
        int edad;
        int altura;
        int peso;
      
        public clsAlumno(String nombre,int edad, int altura, int peso) {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;        
        }

        public clsAlumno()
        {

        }

        public String getNombre()
        {
            return this.nombre;
        }


        public int getEdad()
        {
            return this.edad;
        }

        public int getAltura()
        {
            return this.altura;
        }

        public int getPeso()
        {
            return this.peso;
        }

        public void setNombre(String nombre){
            this.nombre= nombre;
        }

        public void setEdad(int edad){
            this.edad = edad;
        }

        public void setPeso(int peso){
            this.peso = peso;
        }

        public void setAltura(int altura){
            this.altura = altura;
        }
    }
}
