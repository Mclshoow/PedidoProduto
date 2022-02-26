using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoProduto
{
    public class Pedido
    {
        private List<Produto> produtos = new List<Produto>();

        public void valorTotalPedido(int codProd, string cate, decimal preco, string descricao, int quantidade)
        {
            if (quantidade <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantidade), "Adicione algum produto ao pedido.");
            }

            var valorTotal = new Produto(codProd,
                                         cate,
                                         preco,
                                         descricao,
                                         quantidade);
            produtos.Add(valorTotal);
        }

        public string GetHistoricoPedidos()
        {
            var report = new System.Text.StringBuilder();
            decimal balance;
            report.AppendLine("Código\tCategoria\tPreço\tDescrição\tQuantidade");
            foreach(var item in produtos)
            {
                balance = item.Preco * item.Quantidade;
                report.AppendLine($"{item.CodProd}\t{item.Cate}\t\t{balance}\t{item.Descricao}\t\t{item.Quantidade}");
            }
            return report.ToString();
        }

        public string GetSubTotalHistorico()
        {
            var report = new System.Text.StringBuilder();
            decimal valorSomado = 0;
            int QTDE = 0;
            decimal balance = 0;
            report.AppendLine("\t\t\tQTDE Total\tPreço Total\tData Hora");
            foreach (var item in produtos)
            {
                QTDE += item.Quantidade;
                balance = item.Preco * item.Quantidade;
                valorSomado += balance;

            }
            report.AppendLine($"\t\t\t{QTDE}\t\t{valorSomado}\t\t{DateTime.Now}");
            return report.ToString();
        }

    }
}
