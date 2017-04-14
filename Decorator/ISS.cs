namespace Decorator
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto)
        {
        }
        public ISS() : base()
        {
        }

        public override double Calcular(Orcamento orcamento)
        {
            var resultado = orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
            return resultado;
        }

        
    }
}
