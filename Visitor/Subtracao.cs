using System;

namespace Visitor
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avaliar()
        {
            var valorDireita = Direita.Avaliar();
            var valorEsquerda = Esquerda.Avaliar();
            return valorEsquerda - valorDireita;
        }

        public void Imprimir(ImpressoraVisitor impressora)
        {
            impressora.ImprimiSubtracao(this);
        }
    }
}