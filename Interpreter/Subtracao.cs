namespace Interpreter
{
    public class Subtracao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            var valorDireita = direita.Avalia();
            var valorEsquerda = esquerda.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}