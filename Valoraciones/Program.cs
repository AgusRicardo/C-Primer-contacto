using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(LibroValoraciones.nombre);
            // Creamos el objeto libro
            LibroValoraciones libro = new LibroValoraciones(); // Creamos una variable (Objeto de clase) que contiene todos los estados y comportamientos de LibroValoraciones 
            // Asignar valoraciones al objeto
            libro.AgregarValoracion(5.2f); // Le mandamos una valoración y con la F le decimos que es un float
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(7);
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(9);

            // Al llamar a este objeto, borra los valores que ya contenia y le asigna nuevos
            //libro = new LibroValoraciones(); // Creamos un constructor que construye un objeto dentro de la variable
            //libro.AgregarValoracion(2);

            // Creamos otro objeto de clase
            //LibroValoraciones libro2 = libro; // Si se hace esta igualación, van a compartir el mismo espacio de memoria. Libro2 termina pisando a Libro con los datos de ambos
            //libro2.AgregarValoracion(2); // Libro2 toma todas las propiedades de libro mas el nuevo dato

            // Publicar valoraciones
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine("El promedio es: " + publicar.promedioValoraciones);
            Console.WriteLine("Valoracion maxima: " + publicar.valoracionMaxima);
            Console.WriteLine("Valoracion mínima: " + publicar.valoracionMinima);
            Console.ReadLine();
            // valoracionMinima
            // valoracionMaxima
            // promedioValoraciones

        }
    }
}
