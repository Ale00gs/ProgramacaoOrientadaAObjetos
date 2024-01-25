using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstrataFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

       public Dependente(int codigo, string nome, int idade)
       {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
       }
        
        public bool VerificarMaioridade(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public virtual void Mostrar()
        {
            System.Console.WriteLine("Codigo: " + Codigo);
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Idade: " + Idade);
            System.Console.WriteLine();
        }
    }
    
}