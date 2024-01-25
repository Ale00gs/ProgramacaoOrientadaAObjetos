using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstrataFuncionario
{
    public class Comissionado :Funcionario
    {
        public double Porcentagem { get; set; }

        public Comissionado(int c, string n, double s) :base(c,n,s)
        {
            Porcentagem = 0.20;
        }

        public override double CalcularSalario(int diasUteis) //desenvolve o que é necessário
        {
            return Salario = Salario * 30 / diasUteis * Porcentagem + Salario;
        }

        public override void Mostrar()
        {
            base.Mostrar(); //Chamando o método da Superclasse mostrando código, nome e salário
            System.Console.WriteLine("Porcentagem: " + Porcentagem + "\n");

        }
    }
}