using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program : Persona
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Mascota mascota = new Mascota();
            string respuesta;


            Console.WriteLine("¿Cúal es tu nombre?");
            persona.getNombre();
            Console.ReadLine();
            Console.WriteLine("¿Que edad tienes?");
            persona.getEdad();
            Console.ReadLine();
            Console.WriteLine("¿Que tipo de mascota buscas?");
            mascota.getTipo();
            Console.ReadLine();
            Console.WriteLine("¿Que raza buscabas?");
            mascota.getRaza();
            Console.ReadLine();
            Console.WriteLine("¿entre que edad quieres tu mascota?");
            mascota.getEdad();
            Console.ReadLine();
            Console.WriteLine("Quieres adoptarlo? Si/No");
            respuesta = Console.ReadLine();
            Adopcion adopcion = new Adopcion(mascota, persona);
        }
    }
}
