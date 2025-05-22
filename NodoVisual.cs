using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    public class NodoVisual
    {
        public Dispositivo Dispositivo { get; set; }
        public Point Posicion { get; set; }

        public NodoVisual(Dispositivo dispositivo, Point posicion)
        {
            Dispositivo = dispositivo;
            Posicion = posicion;
        }
    }
}
