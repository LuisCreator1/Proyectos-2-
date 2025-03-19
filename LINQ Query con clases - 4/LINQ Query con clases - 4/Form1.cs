using System;
using System.Collections.Generic;
using System.Linq;

class Estudiante
{
    // Definición de atributos
    public string Nombre { get; }
    public string ID { get; }
    public string Curso { get; }
    public double Promedio { get; }

    // Constructor de la clase
    public Estudiante(string nombre, string id, string curso, double promedio)
    {
        Nombre = nombre;
        ID = id;
        Curso = curso;
        Promedio = promedio;
    }

    // Sobrescritura del método ToString para mostrar datos del estudiante
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
        // Creación de la lista de estudiantes con datos de prueba
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana", "100", "Mercadotecnia", 10),
            new Estudiante("Luis", "250", "Orientado a Objetos", 9),
            new Estudiante("Juan", "875", "Programación Básica", 5),
            new Estudiante("Susana", "432", "Mercadotecnia", 8.7),
            new Estudiante("Pablo", "156", "Mercadotecnia", 4.3),
            new Estudiante("Alberto", "456", "Orientado a Objetos", 8.3)
        };

        // Consulta LINQ: Obtener estudiantes reprobados (promedio ≤ 5)
        var reprobados = from e in estudiantes
                         where e.Promedio <= 5.0
                         select e;

        Console.WriteLine("Estudiantes Reprobados:");
        foreach (var estudiante in reprobados)
        {
            Console.WriteLine(estudiante);
        }

        // Consulta LINQ: Obtener solo los nombres de los estudiantes de Mercadotecnia
        var mercadotecnia = from e in estudiantes
                            where e.Curso == "Mercadotecnia"
                            select e.Nombre;

        Console.WriteLine("\nEstudiantes en Mercadotecnia:");
        foreach (var nombre in mercadotecnia)
        {
            Console.WriteLine(nombre);
        }
    }
}
