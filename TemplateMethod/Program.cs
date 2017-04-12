using System;
using System.Linq;

namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Teclado", 250.00));
            orcamento.AdicionarItem(new Item("Monitor", 125.00));
            orcamento.AdicionarItem(new Item("Mouse", 100.00));
            orcamento.AdicionarItem(new Item("Mouse Pad", 80.00));
            orcamento.SetValor(orcamento.Itens.Sum(item => item.Valor));

            TemplateMethodImpostoCondicional icpp = new ICPP();
            var descontoIcpp = icpp.Calcular(orcamento);

            TemplateMethodImpostoCondicional ikcv = new IKCV();
            var descontoIkcv = ikcv.Calcular(orcamento);

            Console.WriteLine($"Desconto ICPP = {descontoIcpp}\nDesconto IKCV = {descontoIkcv}");
            Console.Read();
        }
    }
}
