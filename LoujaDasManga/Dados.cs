using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoujaDasManga
{
    public class Dados
    {
        //propriedades do cliente de acordo com os campos recebidos da tela

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int codigocli;

        public int CodigoCli
        {
            get { return codigocli; }
            set { codigocli = value; }
        }

        private int codigo1;

        public int Codigo1
        {
            get { return codigo1; }
            set { codigo1 = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private int estoque;

        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        private decimal preco;

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }


    }
}
