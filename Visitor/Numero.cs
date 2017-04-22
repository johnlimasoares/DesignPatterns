using System;

namespace Visitor
{
    public class Numero : IExpressao
    {
        public int Valor { get; set; }

        public Numero(int valor)
        {
            this.Valor = valor;
        }

        public int Avaliar()
        {
            return this.Valor;
        }

        public void Imprimir(ImpressoraVisitor impressora)
        {
            impressora.ImprimiNumero(this);
        }
    }
}