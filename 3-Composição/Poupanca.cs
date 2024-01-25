using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composicao
{
    public class Poupanca
    {
        public readonly string id = Guid.NewGuid().ToString(); // Forma 2 (alternativa)

        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    
    public Poupanca() 
    {

    }

    public Poupanca(double _saldo)
    {
        saldo = _saldo;
    }

    public void Sacar(double valor)
    {
        if(saldo >= valor)
        {
            saldo -= valor;
        }
        else
        {
            System.Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public double GerarRendimento()
    {
        return saldo * 0.05;
    }
    }

    
}