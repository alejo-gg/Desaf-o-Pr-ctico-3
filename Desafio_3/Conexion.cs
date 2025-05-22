using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    public class Conexion
    {
        public Dispositivo A { get; set; } // Representa el primer dispositivo en la conexión
        public Dispositivo B { get; set; } // Representa el segundo dispositivo en la conexión

        public Conexion(Dispositivo a, Dispositivo b)
        {
            A = a; // Asigna el primer dispositivo
            B = b; // Asigna el segundo dispositivo
        }
    }
}