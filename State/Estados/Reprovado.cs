using System;

namespace State.Estados
{

    public class Reprovado : IEstado
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos cancelados nao recebem desconto");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento está reprovado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado");
        }
    }
}
