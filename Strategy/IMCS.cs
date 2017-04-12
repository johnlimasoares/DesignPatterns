namespace Strategy
{
    public class IMCS : IImposto
    {
        private decimal aliquota = 0.17M;

        public decimal Calcular(Pedido pedido)
        {
            return pedido.ValorTotalPedido * aliquota;
        }
    }
}