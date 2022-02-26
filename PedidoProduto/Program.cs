using System;

namespace PedidoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido001 = new Pedido();

            pedido001.valorTotalPedido(1, "Fruta", 3, "Laranja", 56);
            pedido001.valorTotalPedido(2, "Fruta", 4, "Limão", 53);
            pedido001.valorTotalPedido(3, "Fruta", 6, "Mamao",  6);



            Console.WriteLine(pedido001.GetHistoricoPedidos());
            Console.WriteLine(pedido001.GetSubTotalHistorico());

        }
    }
}
