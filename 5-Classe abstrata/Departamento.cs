using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string desc)
        {
            Codigo = codigo;
            Descricao = desc;
            VetF = new List<Funcionario>();
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void Listar()
        {
            System.Console.WriteLine(".............................................");
            System.Console.WriteLine("\nLista de Funcionários do departamento " + Descricao + "\n");
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i); //Generalização 
                f.Mostrar();
            }
            System.Console.WriteLine(".............................................\n");
        }

        public void Excluir_frase(int codigo_exclusao)
        {
            string resposta = "Funcionário não encontrado";
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo_exclusao)
                    VetF.Remove(f);
                resposta = "Funcionário excluído";
            }
            Console.WriteLine(resposta);
        }

        public void Excluir(int codigo_exclusao)
        {
            bool resposta = false;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo_exclusao)
                    VetF.Remove(f);
                resposta = true;
            }
            // if (resposta)
            // {
            //     Console.WriteLine("Funcionário excluído com sucesso");
            // }
            // else
            // {
            //     Console.WriteLine("Funcionário não encontrado");
            // }

            //Operador ternário
            System.Console.WriteLine(resposta ? "Funcionário excluído com sucesso. " : "Funcionário não encontrado");
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
             for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }


    public void MostrarQtdeDependentesFuncionario()
    {
        System.Console.WriteLine();
        foreach (var funcionario in VetF)
        {
            int quantidadeDependentes = funcionario.CalcularTotalDependente();
            Console.WriteLine($"O funcionário {funcionario.Nome} tem {quantidadeDependentes} dependente(s).");
        }
        System.Console.WriteLine();
    }
    }

   

}