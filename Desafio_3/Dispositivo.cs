using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    public abstract class Dispositivo
    {
        public string DireccionIP { get; set; }
        public Guid Id { get; private set; }

        public Dispositivo(string ip)
        {
            Id = Guid.NewGuid();
            DireccionIP = ip;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {DireccionIP}";
        }
    }

    public class PC : Dispositivo
    {
        public PC(string ip) : base(ip) { }
    }

    public class Router : Dispositivo
    {
        public string DireccionRed { get; set; }

        public Router(string ip, string red) : base(ip)
        {
            DireccionRed = red;
        }

        public override string ToString()
        {
            return $"Router - {DireccionIP} / Red: {DireccionRed}";
        }
    }
}
