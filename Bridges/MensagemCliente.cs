using System;

namespace Bridges
{
    public class MensagemCliente : IMensagem
    {
        private string Nome;
        public IEnviador Enviador { get; set; }


        public MensagemCliente(string nome)
        {
            this.Nome = nome;
        }

        
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Enviou mensagem para Cliente {Nome}");

        }
    }
}