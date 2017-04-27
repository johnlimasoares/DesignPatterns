using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{/// <summary>
 /// Visitor
 /*
  “Representar uma operação a ser executada nos elementos de uma estrutura de objetos.
  Visitor permite definir uma nova operação sem mudar as classes dos elementos sobre os quais opera.” 
  */
/// </summary>
    public class Program
    {

        public static void Main(string[] args)
        {

            // (1+2) + (20-10)
            var esquerda = new Soma(new Numero(1), new Numero(2));
            var direita = new Subtracao(new Numero(20), new Numero(10));
            var soma = new Soma(direita, esquerda);

            var impressora = new ImpressoraVisitor();
            soma.Imprimir(impressora); // visitor age aqui

            Console.WriteLine(" = " + soma.Avaliar());
            Console.ReadKey();

        }
    }
}
