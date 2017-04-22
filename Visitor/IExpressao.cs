namespace Visitor
{
    public interface IExpressao
    {
        int Avaliar();

        void Imprimir(ImpressoraVisitor impressora);
    }
}
