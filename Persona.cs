using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Persona : Mascota
    {
        private String nombre;
        private String edad;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }


        public String getNombre()
        {
            return nombre;
        }

        public void setEdad(String edad)
        {
            this.edad = edad;
        }
        public String getEdad()
        {
            return edad;
        }
    }
}
