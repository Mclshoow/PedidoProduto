using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoProduto
{
    public class Produto
    {
        #region Propriedades

        public int CodProd { get; private set; }
        public string Cate { get; private set; }
        public decimal Preco { get; private set; }
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }


        #endregion

        #region Construtor

        public Produto(int codProd, string cate, decimal preco, string descricao, int quantidade)
        {
            CodProd = codProd;
            Cate = cate;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }
        #endregion
    }
}
