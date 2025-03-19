using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };

        var valores = from n in numeros
                      where n > 3 && n < 8
                      select n;

        foreach (int num in valores)
        {
            Console.WriteLine(num);
        }

        string[] postres = { "Pay de manzana", "Pastel de chocolate", "Manzana caramelizada", "Fresas con crema" };

        var encontrados = from p in postres
                          where p.Contains("manzana")
                          orderby p
                          select p;

        foreach (string postre in encontrados)
        {
            Console.WriteLine(postre);
        }
       Console.WriteLine("------");

        InformacionResultados(valores);
        Console.WriteLine("------");
        InformacionResultados(encontrados);
    }

    static void InformacionResultados<T>(IEnumerable<T> resultados)
    {
        Console.WriteLine($"Tipo: {resultados.GetType().Name}");
        Console.WriteLine($"Ubicación: {resultados.GetType().Namespace}");
    }
}
