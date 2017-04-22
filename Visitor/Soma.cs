using System;

namespace Visitor
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }


        public int Avaliar()
        {
            var valorDireita = Direita.Avaliar();
            var valorEsquerda = Esquerda.Avaliar();
            return valorEsquerda + valorDireita;
        }

        public void Imprimir(ImpressoraVisitor impressora)
        {
            impressora.ImprimiSoma(this);
        }
    }
}