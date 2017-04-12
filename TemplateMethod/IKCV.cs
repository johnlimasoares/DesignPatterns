using System;

namespace TemplateMethod
{/// <summary>
/// Padrão usado onde há classes com algoritmos semelhantes, deixando a regra na classe abstrata
/// </summary>
    public class IKCV : TemplateMethodImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.7;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5;
        }
    }
}
