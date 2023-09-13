using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class ExAlumno : MiembroDeLaComunidad
    {
        public DateTime FechaSalida { get; set; }

        public ExAlumno(string nombre, string apellido, string cedula, DateTime fechaSalida)
            : base(nombre, apellido, cedula)
        {
            FechaSalida = fechaSalida;
        }

        public void MostrarFechaSalida()
        {
            Console.WriteLine($"Fecha de Salida del Ex Alumno: {FechaSalida.ToShortDateString()}");
        }
    }
}