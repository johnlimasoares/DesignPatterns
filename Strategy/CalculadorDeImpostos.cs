using System;

namespace Strategy
{
    public class CalculadorDeImpostos
    {

        public decimal CalcularImpostos(Pedido pedido, IImposto imposto)
        {
            return imposto.Calcular(pedido);
        }

    }
}