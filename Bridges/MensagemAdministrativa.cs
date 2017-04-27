using System;

namespace Bridges
{
    public class MensagemAdministrativa : IMensagem
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.Nome = nome;
        }
                

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Enviou mensagem para ADM {Nome}");
        }
    }
}