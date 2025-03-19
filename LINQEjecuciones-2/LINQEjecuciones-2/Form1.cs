using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 4, 7, 6, 3, 5, 9, 8, 11 };
        var valores = from n in numeros 
                      where n % 2 == 0 
                      select n;

        foreach (var val in valores)
        {
            Console.WriteLine(val);
        }

        numeros[1] = 12;
        Console.WriteLine("Ejecutando nuevamente");

        foreach (var val in valores)
        {
            Console.WriteLine(val);
        }

        int[] arrayValores = (from n in numeros where n % 2 == 0 select n).ToArray();
        List<int> listValores = (from n in numeros where n % 2 == 0 select n).ToList();

        Console.WriteLine("Array valores:");
        foreach (var val in arrayValores)
        {
            Console.WriteLine(val);
        }

        numeros[0] = 28;
        Console.WriteLine("Array valores después de modificar:");
        foreach (var val in arrayValores)
        {
            Console.WriteLine(val);
        }

        Console.WriteLine("Lista valores:");
        foreach (var val in listValores)
        {
            Console.WriteLine(val);
        }
    }
}
