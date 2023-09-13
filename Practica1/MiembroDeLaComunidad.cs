using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }

        // Constructor
        public MiembroDeLaComunidad(string nombre, string apellido, string cedula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
        }

        // Método 1: Imprimir información del miembro
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Miembro de la Comunidad:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Cedula: {Cedula}");
        }

    }
}