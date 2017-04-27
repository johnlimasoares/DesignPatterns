using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
    public class Program
    {
        private static string usuario = "John";

        public static void Main(string[] args)
        {
            var mensagemPorEmail = new MensagemCliente(usuario);
            mensagemPorEmail.Enviador = new EnviaPorEmail();
            mensagemPorEmail.Envia();

            var mensagemPorSms = new MensagemAdministrativa(usuario);
            mensagemPorSms.Enviador = new EnviaPorSMS();
            mensagemPorSms.Envia();
            Console.ReadKey();
        }
    }
}
