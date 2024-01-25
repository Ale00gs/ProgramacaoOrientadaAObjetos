using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agregacao
{
    public class Venda
    {
        private List<Produto> p;
        private Vendedor v;
        private Comprador c;
        
        public List<Produto> P
        {
            get { return p; }
            set { p = value; }
        }
        
        public Vendedor V
        {
            get { return v; }
            set { v = value; }
        }
        
        public Comprador C
        {
            get { return c; }
            set { c = value; }
        }
        
        public Venda(List<Produto> produto)
        {
            this.P = produto;
        }

        public void Mostrar()
        {
            foreach (Produto p in this.P)
            {
                System.Console.WriteLine("Preço: "+p.Preco+ "\nTamanho: " +p.Tamanho);
            }
        }
    }
}