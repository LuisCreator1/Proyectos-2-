using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine(Singleton.Instance.mensaje);

        
            Singleton.Instance.mensaje = "Cambio de mensaje";

       
            Console.WriteLine(Singleton.Instance.mensaje);

            
        }
    }
}
