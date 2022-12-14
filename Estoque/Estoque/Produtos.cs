using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Produtos
    {
        public string Nome { get; set; }
        public int Qtde { get; set; }
        public double Preco { get; set; }

        public Produtos(string nome, int qtde, double preco)
        {
            this.Nome = nome;
            this.Qtde = qtde;
            this.Preco = preco;
        }

        public string mostrarTexto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nNome: {this.Nome}");
            sb.Append($"\nQuantidade: {this.Qtde}");
            sb.Append($"\nPreco: {this.Preco}");
            return sb.ToString();

        }



    }
}
  

    

