namespace Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public abstract double Calcular(Orcamento orcamento);

        public Imposto(Imposto imposto)
        {
            this.OutroImposto = imposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) {
                return 0;
            }
            var resutado = OutroImposto.Calcular(orcamento);
            return resutado;
        }
    }
}