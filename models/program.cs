using System;
using System.Collections.Generic;
using ProyectoBiblioteca.Models;

namespace ProyectoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carga de al menos 8 títulos con cantidades irregulares de ejemplares (Día 2)
            List<Libro> catalogo = new List<Libro>()
            {
                new Libro("978-987-123-4", "Cien años de soledad", 15, 3),
                new Libro("978-013-235-5", "Clean Code", 42, 5),
                new Libro("978-144-931-8", "El Principito", 8, 1),
                new Libro("978-032-112-5", "Don Quijote de la Mancha", 20, 2),
                new Libro("978-111-800-8", "Fahrenheit 451", 12, 4),
                new Libro("978-059-600-7", "Refactoring", 30, 2),
                new Libro("978-316-148-4", "Crimen y castigo", 5, 1),
                new Libro("978-026-203-3", "Algoritmos en C#", 25, 3)
            };

            Console.WriteLine("=== CATÁLOGO DE LA BIBLIOTECA ESCOLAR (DÍA 2) ===");
            Console.WriteLine($"Total de títulos cargados: {catalogo.Count}\n");

            foreach (var libro in catalogo)
            {
                Console.WriteLine($"ISBN: {libro.Isbn} | Título: {libro.Titulo} | Préstamos: {libro.PrestamosHistoricos} | Disponibles: {libro.EjemplaresDisponibles}");
            }
        }
    }
}
