using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Orcamento orcamentoReforma = new Orcamento();
            orcamentoReforma.AdicionarItem(new Item("Janelas", 5000.00));
            orcamentoReforma.AdicionarItem(new Item("Portas", 3000.00));
            orcamentoReforma.AdicionarItem(new Item("Pisos", 10000.00));
            orcamentoReforma.CalcularValorTotalOrcamento();

            Console.WriteLine($"Orçamento em Aprovação: Valor sem desconto :{orcamentoReforma.Valor}");
            orcamentoReforma.AplicarDesconto();
            Console.WriteLine($"Orçamento em Aprovação: Valor com desconto :{orcamentoReforma.Valor}");

            orcamentoReforma.Aprovar();
            orcamentoReforma.AplicarDesconto();
            Console.WriteLine($"Orçamento Aprovado: Valor com desconto :{orcamentoReforma.Valor}");

            orcamentoReforma.Finalizar();
            Console.WriteLine($"Orçamento Finalizado: Valor Total:{orcamentoReforma.Valor}");
            Console.ReadKey();

        }
    }
}
