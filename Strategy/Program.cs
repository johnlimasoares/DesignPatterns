using System;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pedido = new Pedido(100.00M);

            var calculador = new CalculadorDeImpostos();
            decimal impostoICMS = calculador.CalcularImpostos(pedido, new IMCS());
            Console.WriteLine(impostoICMS);

            decimal impostoIPI = calculador.CalcularImpostos(pedido, new IPI());
            Console.WriteLine(impostoIPI);

            Console.ReadKey();

        }
    }
}
