using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Horista : Funcionario
    {
        public int QtdeHorasSemana { get; set; }

        public Horista(int codigo, string nome, double salario, int qtdeHorasSemana) : base(codigo, nome, salario)
        {
            QtdeHorasSemana = qtdeHorasSemana;
        }
        
        public override void MostrarDados() 
        {
            base.MostrarDados();
            System.Console.WriteLine("qtd Horas Semana: "+ QtdeHorasSemana);            

        }
    }
}