// função Main() implícita
using Atividade_Construtor;
//tipo / obj / alocação de memoria / construtor
//instanciar obj
Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario("Fulano");
Funcionario f3 = new Funcionario("Ciclano", 1000);

f3.CalcularReajuste(1000);

System.Console.WriteLine("Qtd Instâncias: " + Funcionario.MostrarTotalFuncionarios());
