// Método Main()
using InterfaceATV;

ContaCorrente c1 = new ContaCorrente(500, "Fulano");
SeguroDeVida s1 = new SeguroDeVida();


TotalizadorDeTributos t1 = new TotalizadorDeTributos();
t1.Adiciona(c1);
System.Console.WriteLine("\nValor do saldo do(a) " + c1.Nome + " é: " + c1.Saldo);
System.Console.WriteLine("Valor do tributo: " + c1.CalculaTributos());
t1.Adiciona(s1);
System.Console.WriteLine("Total: " + t1.Total + "\n" );

