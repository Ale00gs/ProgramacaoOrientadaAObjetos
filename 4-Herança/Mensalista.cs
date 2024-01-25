using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Mensalista : Funcionario
    {
        public int QtdeHorasTrabalhadas { get; set; }
        
        public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas) : base(codigo, nome, salario)
        {
            QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
            
        }

        public override void MostrarDados() 
        {
            base.MostrarDados();
            System.Console.WriteLine("qtd Horas Trabalhadas: "+ QtdeHorasTrabalhadas);
            
        }
    }
}