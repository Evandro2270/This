using System.Globalization;

namespace VendasPodutos
{
    internal class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
        public double ValorTotalemEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CI)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalemEstoque().ToString("F2", CI);

        }

    }
}
