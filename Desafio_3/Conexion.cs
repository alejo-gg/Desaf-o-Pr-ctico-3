using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    public class Conexion
    {
        public Dispositivo A { get; set; }
        public Dispositivo B { get; set; }

        public Conexion(Dispositivo a, Dispositivo b)
        {
            A = a;
            B = b;
        }
    }
}
