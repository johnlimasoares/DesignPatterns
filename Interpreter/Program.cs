using System;
using System.Linq.Expressions;

namespace Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // (1+2) + (20-10)
            var esquerda = new Soma(new Numero(1),new Numero(2));
            var direita = new Subtracao(new Numero(20),new Numero(10));
            var soma = new Soma(direita, esquerda);
            Console.WriteLine(soma.Avalia());
            Console.ReadKey();



            //nativo c#
            var expression = Expression.Divide(Expression.Constant(10m), Expression.Constant(2m));
            var funcao = Expression.Lambda<Func<decimal>>(expression).Compile();

            //Console.WriteLine(funcao());
            //Console.ReadKey();

        }
    }
}
