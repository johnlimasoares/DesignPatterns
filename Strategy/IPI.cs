using System;

namespace Strategy
{
    public class IPI : IImposto
    {
        private decimal aliquota = 0.08M;

        public decimal Calcular(Pedido pedido)
        {
            return pedido.ValorTotalPedido * aliquota;
        }
    }
}