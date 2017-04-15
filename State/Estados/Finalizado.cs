using System;

namespace State.Estados
{
    public class Finalizado : IEstado
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados nao recebem desconto");
        }
               

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento está finalizado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento está finalizado");
        }
    }
}
