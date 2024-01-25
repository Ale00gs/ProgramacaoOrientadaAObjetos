using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Construtor
{
    public class Funcionario
    {
        private int codigo_funcionario, qtd;
        private string nome = "";
        private double salario, reajuste, salarioNovo;
       
        public static int qtdFuncionario = 0;
        protected static int codFuncionario = 0;
        // encapsulamento
        public int Codigo_funcionario { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Reajuste { get; set; }
        public double SalarioNovo { get; set; }
        
        // métodos
        public void CalcularReajuste(double Salario)
        {
            System.Console.Write("\nInforme o valor(%) do reajuste salarial: ");
            Reajuste = Convert.ToDouble(Console.ReadLine());
        
            SalarioNovo = ((Salario * Reajuste) / 100) + Salario;

            System.Console.WriteLine("O novo salário do funcionário(a) " +Nome+ " é: "+string.Format("{0:0.00}",SalarioNovo)+" reais.\n");
        }

        public static int MostrarTotalFuncionarios()
        {
            return qtdFuncionario;
        }


        static Funcionario()
        {
           codFuncionario = 100;

        }
         //Construtor
        public Funcionario()
        {
            this.Codigo_funcionario = codFuncionario + qtdFuncionario;
            System.Console.WriteLine("Construtor 1 executado");
            System.Console.WriteLine("Conteúdo do atributo código: " + Codigo_funcionario);
            System.Console.WriteLine("Conteúdo do atributo nome: " + Nome);
            System.Console.WriteLine("Conteúdo do atributo salário: " + Salario);
            System.Console.WriteLine();
            Funcionario.qtdFuncionario = qtdFuncionario + 1;

        }

        public Funcionario(string Nome)
        {
            this.Codigo_funcionario = codFuncionario + qtdFuncionario;
            System.Console.WriteLine("Construtor 2 executado");
            System.Console.WriteLine("Conteúdo do atributo código: " + Codigo_funcionario);
            System.Console.WriteLine("Conteúdo do atributo nome: " + Nome);
            System.Console.WriteLine("Conteúdo do atributo salário: " + Salario);
            System.Console.WriteLine();
            Funcionario.qtdFuncionario = qtdFuncionario + 1;
        }

        public Funcionario(string Nome, double Salario)
        {
            this.Codigo_funcionario = codFuncionario + qtdFuncionario;
            System.Console.WriteLine("Construtor 3 executado");
            System.Console.WriteLine("Conteúdo do atributo código: " + Codigo_funcionario);
            System.Console.WriteLine("Conteúdo do atributo nome: " + Nome);
            System.Console.WriteLine("Conteúdo do atributo salário: " + string.Format("{0:0.00}",Salario));
            System.Console.WriteLine();
            Funcionario.qtdFuncionario = qtdFuncionario + 1;
            
        }
    }
}