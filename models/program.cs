using System;
using System.Collections.Generic;
using ProyectoBiblioteca.Models;

namespace ProyectoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Catálogo inicial con 8 libros
            List<Libro> catalogo = new List<Libro>()
            {
                new Libro("978-987-123-4", "Cien años de soledad", 15, 3),
                new Libro("978-013-235-5", "Clean Code", 42, 5),
                new Libro("978-144-931-8", "El Principito", 8, 1),
                new Libro("978-032-112-5", "Don Quijote de la Mancha", 20, 2),
                new Libro("978-054-792-8", "El Hobbit", 12, 4),
                new Libro("978-014-044-9", "La Odisea", 6, 0),
                new Libro("978-843-760-4", "Ficciones", 10, 2),
                new Libro("978-006-112-0", "Matar a un ruiseñor", 9, 3)
            };

            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("   SISTEMA DE GESTIÓN DE BIBLIOTECA");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Ver catálogo completo");
                Console.WriteLine("2. Registrar préstamo de libro");
                Console.WriteLine("3. Registrar devolución de libro");
                Console.WriteLine("4. Salir");
                Console.WriteLine("========================================");
                Console.Write("Selecciona una opción (1-4): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarCatalogo(catalogo);
                        break;
                    case "2":
                        PrestarLibro(catalogo);
                        break;
                    case "3":
                        DevolverLibro(catalogo);
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("\n¡Gracias por usar el sistema!");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Presiona ENTER para intentar de nuevo.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void MostrarCatalogo(List<Libro> catalogo)
        {
            Console.Clear();
            Console.WriteLine("--- CATÁLOGO DE LIBROS ---");
            foreach (var libro in catalogo)
            {
                Console.WriteLine($"ISBN: {libro.ISBN} | Título: {libro.Titulo} | Disponibles: {libro.EjemplaresDisponibles} | Prestados: {libro.PrestamosHistoricos}");
            }
            Pausar();
        }

        static void PrestarLibro(List<Libro> catalogo)
        {
            Console.Clear();
            Console.WriteLine("--- PRESTAR LIBRO ---");
            Console.Write("Ingresa el ISBN del libro: ");
            string isbn = Console.ReadLine();

            Libro libroEncontrado = catalogo.Find(l => l.ISBN == isbn);

            if (libroEncontrado != null)
            {
                if (libroEncontrado.EjemplaresDisponibles > 0)
                {
                    libroEncontrado.EjemplaresDisponibles--;
                    libroEncontrado.PrestamosHistoricos++;
                    Console.WriteLine($"\n✅ Préstamo exitoso de '{libroEncontrado.Titulo}'. Quedan {libroEncontrado.EjemplaresDisponibles} disponibles.");
                }
                else
                {
                    Console.WriteLine($"\n❌ No hay ejemplares disponibles de '{libroEncontrado.Titulo}'.");
                }
            }
            else
            {
                Console.WriteLine("\n❌ Libro no encontrado con ese ISBN.");
            }
            Pausar();
        }

        static void DevolverLibro(List<Libro> catalogo)
        {
            Console.Clear();
            Console.WriteLine("--- DEVOLVER LIBRO ---");
            Console.Write("Ingresa el ISBN del libro a devolver: ");
            string isbn = Console.ReadLine();

            Libro libroEncontrado = catalogo.Find(l => l.ISBN == isbn);

            if (libroEncontrado != null)
            {
                libroEncontrado.EjemplaresDisponibles++;
                Console.WriteLine($"\n✅ Devolución exitosa. Ahora hay {libroEncontrado.EjemplaresDisponibles} ejemplares de '{libroEncontrado.Titulo}'.");
            }
            else
            {
                Console.WriteLine("\n❌ Libro no encontrado.");
            }
            Pausar();
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresiona ENTER para volver al menú...");
            Console.ReadLine();
        }
    }
}
