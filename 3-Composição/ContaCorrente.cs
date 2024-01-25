using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composicao
{
    public class ContaCorrente
    {
        public readonly string id = Guid.NewGuid().ToString(); // Forma 2 (alternativa)
        
        private double saldo;
        private int chequeEspecial;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int ChequeEspecial
        {
            get { return chequeEspecial; }
            set { chequeEspecial = value; }
        }
        
        public ContaCorrente(int chequeEspecial) 
        {
            ChequeEspecial = chequeEspecial;
        }

        public ContaCorrente(double _saldo, int _chequeEspecial)
        {
            Saldo = _saldo;
            ChequeEspecial = _chequeEspecial;
        }

        public void Sacar(double valor)
        {
            if((Saldo + ChequeEspecial) >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente");
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void GerarExtrato()
        {
            System.Console.WriteLine($"Saldo: {Saldo:C} ");
            System.Console.WriteLine($"Cheque Especial: {ChequeEspecial:C} ");
        }
        
    }

    
}