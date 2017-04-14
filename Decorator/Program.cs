using System;
using System.Linq;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Soja", 100.00));
            orcamento.AdicionarItem(new Item("Milho", 50.00));
            orcamento.AdicionarItem(new Item("Arroz", 50.00)); 
            orcamento.AdicionarItem(new Item("Feijão", 100.00));
            orcamento.SetValor(orcamento.Itens.Sum(item => item.Valor));
            var impostoIcms = new ICMS(new ISS());

            var valorTotalImpostos = impostoIcms.Calcular(orcamento);

            Console.WriteLine(valorTotalImpostos);
            Console.ReadKey();

        }
    }
}
