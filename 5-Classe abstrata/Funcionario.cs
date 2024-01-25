using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstrataFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }
        public List<Dependente> VetD { get; set; }
        public Funcionario(int c, string n, double s)
        {
            Codigo = c;
            Nome = n;
            Salario = s;
            VetD = new List<Dependente>();
        }

        public abstract double CalcularSalario(int diasUteis);
        public virtual void Mostrar()
        {
            System.Console.WriteLine("\nCódigo: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);

        }

        public int CalcularTotalDependente()
        {
            return VetD.Count;
        }
       

        public void AdicionarDependente(Dependente NovoDependente)
        {
            VetD.Add(NovoDependente);
            System.Console.WriteLine("Dependente adicionado com sucesso!");
        }

        public void RemoverDependentesMaioridade(int codigo_exclusao)
        {
            string resposta = "Dependente não encontrado.";
            for (int i = 0; i < VetD.Count; i++)
            {
                Dependente d = VetD.ElementAt<Dependente>(i);
                if (d.Codigo == codigo_exclusao)
                    VetD.Remove(d);
                resposta = "Dependente excluído";
            }
            Console.WriteLine(resposta);
        }

        public void ListarDependentes()
        {
            System.Console.WriteLine(".............................................");
            System.Console.WriteLine("\nLista de Dependentes do Funcionário " + Nome + "\n");
            for (int i = 0; i < VetD.Count; i++)
            {
                Dependente d = VetD.ElementAt<Dependente>(i); //Generalização 
                d.Mostrar();
            }
            System.Console.WriteLine(".............................................\n");
        }
    
    }
}