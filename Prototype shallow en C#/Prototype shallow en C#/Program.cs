using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_shallow_en_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal oAnimal = new Animal() { Nombre = "Oveja Dolly", Patas = 4 };
            Animal oAnimalClonado = oAnimal.Clone() as Animal;
            oAnimalClonado.Patas = 5;

            Console.WriteLine(oAnimal.Patas);
        }

    }
}

            
    