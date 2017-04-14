namespace Decorator
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
        }
        public ICMS() : base()
        {
        }

        public override double Calcular(Orcamento orcamento)
        {
            var resultado = orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
            return resultado;
        }
    }
}
