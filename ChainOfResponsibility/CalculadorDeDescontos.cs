namespace ChainOfResponsibility
{
    public class CalculadorDeDescontos
    {
        public double Calcular(Orcamento orcamento)
        {
            IDesconto descontoMaisCincoItens = new DescontoPorMaisDeCincoItens();
            IDesconto descontoMaisQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
            IDesconto semDesconto = new SemDesconto();

            descontoMaisCincoItens.Proximo = descontoMaisQuinhentosReais;
            descontoMaisQuinhentosReais.Proximo = semDesconto;

            return descontoMaisCincoItens.Desconta(orcamento);
        }
    }
}