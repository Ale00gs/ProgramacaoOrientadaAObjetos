using Composicao;
// Função Main() implícita
// A composição é feita dentro do construtor

// instanciação dos objetos
// ContaCorrente c1 = new ContaCorrente();
// c1.Depositar(100);
// c1.GerarExtrato();

// Poupanca p1 = new Poupanca();
// p1.Sacar(50);
// p1.GerarRendimento();

/*
  ==========
  Forma 1
  ==========
*/

// Banco b1 = new Banco();

// List<Poupanca> contasPoupanca = new List<Poupanca>();
// List<ContaCorrente> contasCorrente = new List<ContaCorrente>();

// ContaCorrente c1 = new ContaCorrente(1000);
// contasCorrente.Add(c1);

// b1.AbrirConta(c1);
// c1.Depositar(200);

// Poupanca p1 = new Poupanca();
// contasPoupanca.Add(p1);

// c1.Sacar(100);

// b1.AbrirPoupanca(p1);

// p1.Depositar(100);

// c1.GerarExtrato();
// p1.GerarRendimento();

// foreach (var contaCorrente in contasCorrente)
// {
//     contaCorrente.GerarExtrato();
// }

// foreach (var contaPoupanca in contasPoupanca)
// {
//     System.Console.WriteLine("========================");
//     System.Console.WriteLine("Saldo da Conta Poupanca: " + contaPoupanca.Saldo);
//     System.Console.WriteLine("========================");
//     System.Console.WriteLine("Saldo da Conta Poupanca + rendimento: " + contaPoupanca.Saldo + contaPoupanca.GerarRendimento());
//     System.Console.WriteLine("========================");
// }

/*
  ==========
  Forma 2 (alternativa) só descomentar e comentar a Forma 1
  ==========
*/

Banco b1 = new Banco();

ContaCorrente contaCorrente1B1 = b1.AbrirConta(1000);

Poupanca contaPoupanca1B1 = b1.AbrirPoupanca();

b1.DepositarContaCorrente(contaCorrente1B1.id, 100);

b1.DepositarPoupanca(contaPoupanca1B1.id, 100);

b1.ExtratoContaCorrente();
b1.ExtratoContaPoupanca();

b1 = null;
GC.Collect();