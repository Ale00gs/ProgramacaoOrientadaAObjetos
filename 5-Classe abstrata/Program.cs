// Main Implícita
using abstrataFuncionario;
// Funcionario f = new Funcionário(); Não é permitida a instância 

// Assalariado a1 = new Assalariado(1, "Leo", 1000);
// Assalariado a2 = new Assalariado(2, "Lia", 1000);
// Comissionado c1 = new Comissionado(3, "Bia", 1000);
// Comissionado c2 = new Comissionado(4, "Boa", 1000);

// // a1.Mostrar();
// // a1.CalcularSalario(30);
// // c1.Mostrar();
// // c1.CalcularSalario(30); // 30 dias trabalhados 
// // c1.Mostrar();

// Departamento d1 = new Departamento(50,"TI");
// Departamento d2 = new Departamento(51,"RH");
// d1.Admitir(a1);

// d1.Admitir(a2);
// d1.Listar();
// d2.Admitir(c1);
// d2.Listar();

// d1.Excluir(1);
// d1.Listar();
// d1.Excluir(1);

// double folha = d1.CalcularFolha(30);
// System.Console.WriteLine($"Folha de pagamento do departamento {d1.Descricao} {folha:C}");

// System.Console.WriteLine($"Folha de pagamento do departamento {d2.Descricao} {folha:C}");

// ------------------------------------------
//Instancia dos funcionários
Assalariado a3 = new Assalariado(5,"Fulano", 2000);
Comissionado c3 = new Comissionado(6,"Ciclano", 3000);
//Instancia dos Dependentes
Dependente de1 = new Dependente(1,"Filho 1",10);
Dependente de2 = new Dependente(2,"Filho 2",18);
Dependente de3 = new Dependente(3,"Filho 3",12);
//Instancia do Departamento
Departamento d3 = new Departamento(52,"Contabilidade");
// Departamento admitindo funcionários
d3.Admitir(a3);
d3.Admitir(c3);
d3.Listar();
d3.MostrarQtdeDependentesFuncionario(); //está zerado

// Dependentes adicionados e listados
a3.AdicionarDependente(de1);
a3.AdicionarDependente(de2);
c3.AdicionarDependente(de3);
a3.ListarDependentes();
c3.ListarDependentes();
System.Console.WriteLine( "Calculando o total de Dependentes do " + a3.Nome + ": "+a3.CalcularTotalDependente());
System.Console.WriteLine( "Calculando o total de Dependentes do " + c3.Nome + ": "+c3.CalcularTotalDependente());
d3.MostrarQtdeDependentesFuncionario();

// Dependente removido e listado
a3.RemoverDependentesMaioridade(de2.Codigo);
a3.ListarDependentes();
d3.MostrarQtdeDependentesFuncionario();
