using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Estudiante
{
    public string Nombre { get; }
    public string ID { get; }
    public string Curso { get; }
    public double Promedio { get; }

    public Estudiante(string nombre, string id, string curso, double promedio)
    {
        Nombre = nombre;
        ID = id;
        Curso = curso;
        Promedio = promedio;
    }

    public override string ToString()
    {
        return string.Format("Nombre: {0}, ID: {1}, Curso: {2}, Promedio: {3}",
            Nombre, ID, Curso, Promedio);
    }
}

class Program
{
    static void Main()
    {
        // Creación de un ArrayList con diferentes tipos de datos
        ArrayList lista = new ArrayList();
        lista.AddRange(new object[] { "Hola", 5, 6.7, false, 4, 2, "Saludos", 3.5, 3 });

        // Uso de OfType<T> para obtener solo los valores enteros
        var enteros = lista.OfType<int>();

        Console.WriteLine("Elementos enteros en la lista:");
        foreach (var num in enteros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Creación de un ArrayList de estudiantes
        ArrayList listaEstudiantes = new ArrayList
        {
            new Estudiante("Ana", "100", "Mercadotecnia", 10),
            new Estudiante("Luis", "250", "Orientado a Objetos", 9),
            new Estudiante("Juan", "875", "Programación Básica", 5),
            new Estudiante("Susana", "432", "Mercadotecnia", 8.7),
            new Estudiante("Pablo", "156", "Mercadotecnia", 4.3),
            new Estudiante("Alberto", "456", "Orientado a Objetos", 8.3)
        };

        // Conversión del ArrayList a una colección compatible con LINQ usando OfType<Estudiante>
        var estudiantesLinq = listaEstudiantes.OfType<Estudiante>();

        // Consulta LINQ para obtener estudiantes reprobados (promedio ≤ 5)
        var reprobados = from e in estudiantesLinq
                         where e.Promedio <= 5.0
                         select e;

        Console.WriteLine("\nEstudiantes Reprobados:");
        foreach (var estudiante in reprobados)
        {
            Console.WriteLine(estudiante);
        }

        // Uso de proyección con tipos anónimos para devolver solo Nombre y Promedio
        var proyeccion = from e in estudiantesLinq
                         select new { e.Nombre, e.Promedio };

        Console.WriteLine("\nProyección de datos (Nombre y Promedio):");
        foreach (var item in proyeccion)
        {
            Console.WriteLine("Nombre: {0}, Promedio: {1}", item.Nombre, item.Promedio);
        }
    }
}
