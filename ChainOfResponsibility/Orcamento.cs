using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
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
