using System;
using System.Collections.Generic;
using System.Linq;

class ClaseExplicita
{
    // Definir un arreglo de postres como estático
    private static string[] postres = { "Pay de manzana", "Pastel de chocolate", "Manzana caramelizada", "Fresas con crema" };

    // Método que devuelve postres que contienen "manzana"
    public static IEnumerable<string> ObtenerPostres()
    {
        var encontrados = from postre in postres
                          where postre.Contains("manzana")
                          select postre;
        return encontrados;
    }

    // Método para obtener números pares
    public static IEnumerable<int> ObtenerNumerosPares()
    {
        int[] numeros = { 15, 4, 7, 6, 3, 5, 9, 8, 11 };
        var pares = from numero in numeros
                    where numero % 2 == 0
                    select numero;
        return pares;
    }

    // Método para obtener números impares de forma inmediata
    public static int[] ObtenerNumerosImpares()
    {
        int[] numeros = { 15, 4, 7, 6, 3, 5, 9, 8, 11 };
        var resultados = (from numero in numeros
                          where numero % 2 != 0
                          select numero).ToArray();
        return resultados;
    }
}

class Program
{
    static void Main()
    {
        // Invocar ObtenerNumerosPares y mostrar resultados
        IEnumerable<int> resultadoPares = ClaseExplicita.ObtenerNumerosPares();
        Console.WriteLine("Números pares:");
        foreach (int numero in resultadoPares)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        // Invocar ObtenerPostres y mostrar resultados
        IEnumerable<string> resultadoPostres = ClaseExplicita.ObtenerPostres();
        Console.WriteLine("Postres con 'manzana':");
        foreach (string postre in resultadoPostres)
        {
            Console.WriteLine(postre);
        }

        // Invocar ObtenerNumerosImpares y mostrar resultados
        int[] resultadoImpares = ClaseExplicita.ObtenerNumerosImpares();
        Console.WriteLine("Números impares:");
        foreach (int numero in resultadoImpares)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
