using System;

namespace State.Estados
{
    public class Aprovado : IEstado
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            orcamento.SetValorTotalOrcamentoComDesconto(orcamento.Valor - (orcamento.Valor * 0.02));
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está Aprovado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
