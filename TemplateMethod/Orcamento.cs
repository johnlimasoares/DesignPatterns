using System.Collections.Generic;

namespace TemplateMethod
{
    public class Orcamento
    {
        public double Valor { get; private set;}
        public List<Item> Itens { get; private set; }

        public Orcamento() {
            this.Itens = new List<Item>();
        }   

        public void AdicionarItem(Item item) {
            this.Itens.Add(item);
        }

        public void SetValor(double valor) {
            this.Valor = valor;
        }
    }
}
