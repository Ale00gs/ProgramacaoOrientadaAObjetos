using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceATV
{
    public class TotalizadorDeTributos
    {
        public double Total { get; set; }
        public void Adiciona(Itributavel t)
        {
            this.Total += t.CalculaTributos();
        }
    }
}