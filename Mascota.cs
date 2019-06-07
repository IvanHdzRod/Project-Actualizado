using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Mascota 
    {
        private String raza;
        private String tipo;
        private String edad;

        public void setRaza(String raza)
            {
             this.raza=raza;
            }   
        public String getRaza()
            {
            return raza;
             }

        public void setTipo(String tipo)
            {
             this.tipo=tipo;
            }   
        public String getTipo()
            {
            return tipo;
             }

        public void setEdad(String edad)
            {
             this.edad=edad;
            }   
        public String getEdad()
            {
            return edad;
             }  
    }
}
