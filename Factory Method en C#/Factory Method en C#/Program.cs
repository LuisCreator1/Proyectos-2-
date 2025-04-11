using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_en_C_
{
    class Program
    {
        static void Main()
        {
            BebidaEmbriagante bebida;

            bebida = Creador.CrearBebida(Creador.VINO_TINTO);
            Console.WriteLine(bebida.CuantoMeEmbriaga()); // 20

            bebida = Creador.CrearBebida(Creador.CERVEZA);
            Console.WriteLine(bebida.CuantoMeEmbriaga()); // 5
        }
    }
