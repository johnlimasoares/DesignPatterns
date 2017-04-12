namespace Strategy
{
    public class Pedido
    {
        public decimal ValorTotalPedido { get; internal set; }

        public Pedido(decimal valorTotalPedido) {
            this.ValorTotalPedido = valorTotalPedido;
        }

    }
}