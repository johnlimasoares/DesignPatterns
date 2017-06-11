using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var listaString = new List<object>();
                listaString.Add("Ola");
                listaString.Add("Mundo");

                var listUnmodified = new ListUnmodified(listaString);
                listUnmodified.Add("Novo");

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
                Console.ReadKey();

            }

        }
    }
}
