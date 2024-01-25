using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Funcionario
    {
        
        protected int Codigo { get; set; }
        protected string Nome { get; set; }
        protected double Salario { get; set; }
        
        public Funcionario(int c, string n, double s) //Inicializar as variáveis
        {
            Codigo = c;
            Nome = n;
            Salario = s;
        }

        public virtual void MostrarDados() 
        {
            System.Console.WriteLine();
            System.Console.WriteLine("---DADOS DO FUNCIONÁRIO---");
            System.Console.WriteLine("Código: "+ Codigo);
            System.Console.WriteLine("Nome: "+ Nome);
            System.Console.WriteLine("Salário: "+ Salario);
        }

    }
}