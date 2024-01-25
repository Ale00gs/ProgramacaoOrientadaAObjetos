using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agregacao
{
    public class Produto
    {
        private float preco;
        private int tamanho;

        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        
    }
}