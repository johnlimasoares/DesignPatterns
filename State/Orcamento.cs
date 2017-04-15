using State.Estados;
using System.Collections.Generic;
using System.Linq;
using System;

namespace State
{
    public class Orcamento
    {
        public double Valor { get; private set; }
              

        public List<Item> Itens { get; private set; }
        public IEstado EstadoAtual { get; set; }


        public Orcamento()
        {
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicarDesconto()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
        }

        public void CalcularValorTotalOrcamento()
        {
            this.Valor = this.Itens.Sum(x => x.Valor);
        }

        public void SetValorTotalOrcamentoComDesconto(double valorComDesconto)
        {
            this.Valor = valorComDesconto;
        }

        public void Aprovar()
        {
            EstadoAtual.Aprovar(this);
        }

        public void Reprovar()
        {
            EstadoAtual.Reprovar(this);
        }

        public void Finalizar()
        {
            EstadoAtual.Finalizar(this);
        }

    }

}
