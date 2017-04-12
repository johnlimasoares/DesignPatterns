using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculadorDesconto = new CalculadorDeDescontos();

            var orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Mouse", 50.00));
            orcamento.AdicionarItem(new Item("Teclado", 150.00));
            orcamento.AdicionarItem(new Item("Monitor", 550.00));
            orcamento.SetValor(orcamento.Itens.Sum(item => item.Valor));

            var desconto = calculadorDesconto.Calcular(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
