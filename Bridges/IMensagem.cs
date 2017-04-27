namespace Bridges
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Envia();
        string Formata();
    }
}