using Agregacao;
//Função Main() implícita

//instanciação do obj Produto
Produto p1 = new Produto();
p1.Preco = 40;
p1.Tamanho = 35;

List<Produto> Itens = new List<Produto>();
Itens.Add(p1);

//instanciação do obj Venda
Venda ve = new Venda( Itens);

//instanciação do obj Comprador
Comprador c1 = new Comprador();
c1.Verba = 50;

//instanciação do obj Vendedor
Vendedor v1 = new Vendedor();
v1.Comissao = 150;

ve.Mostrar();





