using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto_TP04
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Preco { get; set;}
        public string Quantidade { get; set;}
        public string Descricao { get; set;}

        public Produto(string nome, string preco, string quantidade, string descricao)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Descricao = descricao;
        }
    }
}
