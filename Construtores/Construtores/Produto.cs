using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        private string nome;
        public double preco { get; private set; }   
        public int quantidade { get; private set; }

        public string Nome
        {
            get { return nome; }
            set {
                if (value != null && value.Length < 1)
                {
                    nome = value;
                }
            }
        }

        public double Total()
        {
            return quantidade * preco;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }

        public override string ToString()
        {
            return nome + ", $" + preco + ", " + quantidade + " unidades, total = $" + Total() ;
        }

    }
}
