using System;

namespace Visitor
{
    public class ImpressoraVisitor
    {

        public void ImprimiSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Imprimir(this);
            Console.Write("+");
            soma.Direita.Imprimir(this);
            Console.Write(")");
        }

        public void ImprimiSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Imprimir(this);
            Console.Write("-");
            subtracao.Direita.Imprimir(this);
            Console.Write(")");
        }

        public void ImprimiNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
