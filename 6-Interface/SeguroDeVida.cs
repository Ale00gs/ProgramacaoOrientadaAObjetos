using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceATV
{
    public class SeguroDeVida : Itributavel
    {

        public double CalculaTributos() 
        {
            return 75;
        }
       
    }
}