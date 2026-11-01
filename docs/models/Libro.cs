using System;

namespace ProyectoBiblioteca.Models
{
    public class Libro
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public int PrestamosHistoricos { get; set; }
        public int EjemplaresDisponibles { get; set; }

        // Constructor para inicializar el libro
        public Libro(string isbn, string titulo, int prestamosHistoricos, int ejemplaresDisponibles)
        {
            Isbn = isbn;
            Titulo = titulo;
            PrestamosHistoricos = prestamosHistoricos;
            EjemplaresDisponibles = ejemplaresDisponibles;
        }
    }
}
