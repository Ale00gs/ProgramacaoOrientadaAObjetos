using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceATV
{
    public class ContaCorrente : Itributavel
    {
        public double Saldo { get; set; }

        public string Nome { get; set; }
        public ContaCorrente(double saldo, string nome)
        {
            Saldo = saldo;
            Nome = nome;
        }
        public double CalculaTributos() 
        {
            double imposto =  (Saldo * 5) / 100;
            return imposto; 
        } 
    }
}