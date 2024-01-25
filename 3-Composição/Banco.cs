using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composicao
{
    public class Banco
    {
        private List<Poupanca> poups = new List<Poupanca>();
        private List<ContaCorrente> contas = new List<ContaCorrente>();

        public List<Poupanca> Poups
        {
            get { return poups; }
            set { poups = value; }
        }

        public List<ContaCorrente> Contas
        {
            get { return contas; }
            set { contas = value; }
        }

        public void AbrirPoupanca(Poupanca poupanca)
        {
            Poups.Add(poupanca);
        }
        
        public void AbrirConta(ContaCorrente contaCorrente)
        {
            Contas.Add(contaCorrente);
        }

        // Destrutor
        ~Banco()
        {
            Poups = null;
            Contas = null;
            System.Console.WriteLine("Destruindo objetos");
        }

        /*
        ==========
        Forma 2 (alternativa)
        ==========
        */
        public Poupanca AbrirPoupanca()
        {
            Poupanca conta = new Poupanca();
            Poups.Add(conta);
            return conta;
        }

        public ContaCorrente AbrirConta(int valorChequeEspecial)
        {
            ContaCorrente conta = new ContaCorrente(valorChequeEspecial);
            Contas.Add(conta);
            return conta;
        }
        
        public void DepositarContaCorrente(string identificadorContaCorrente, double saldo)
        {
            ContaCorrente? contaEncontrada = Contas.Find(c => c.id == identificadorContaCorrente);

            contaEncontrada?.Depositar(saldo);
        }

        public void ExtratoContaCorrente()
        {
            foreach (ContaCorrente contaCorrente in Contas)
            {
                System.Console.WriteLine("========================");
                System.Console.WriteLine("Saldo da Conta Corrente: ");
                contaCorrente.GerarExtrato();
                System.Console.WriteLine("========================");
            }
        }

        public void DepositarPoupanca(string identificadorPoupanca, double saldo)
        {
            Poupanca? contaEncontrada = Poups.Find(c => c.id == identificadorPoupanca);

            contaEncontrada?.Depositar(saldo);
        }

        public void ExtratoContaPoupanca()
        {
            foreach (Poupanca poupanca in Poups)
            {
                System.Console.WriteLine("========================");
                System.Console.WriteLine("Saldo da Conta Poupanca: " + poupanca.Saldo);
                System.Console.WriteLine("========================");
                double saldoComRendimento = poupanca.Saldo + poupanca.GerarRendimento();
                System.Console.WriteLine("Saldo da Conta Poupanca + rendimento: " + saldoComRendimento);
                System.Console.WriteLine("========================");
            }
        }
    }
}