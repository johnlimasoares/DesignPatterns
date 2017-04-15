using System;

namespace State.Estados
{
    public class EmAprovacao : IEstado
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            orcamento.SetValorTotalOrcamentoComDesconto(orcamento.Valor - (orcamento.Valor * 0.05));
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orcamento Em Aprovação não pode ser finaizado.");
        }
    }
}
