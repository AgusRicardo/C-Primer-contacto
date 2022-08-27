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
            LibroValoraciones libro = new LibroValoraciones(); // Creamos una variable (Objeto de clase) que contiene todos los estados y comportamientos de LibroValoraciones 
            libro.AgregarValoracion(3.5f); // Le mandamos una valoración y con la F le decimos que es un float
            libro.AgregarValoracion(5);

            // Al llamar a este objeto, borra los valores que ya contenia y le asigna nuevos
            //libro = new LibroValoraciones(); // Creamos un constructor que construye un objeto dentro de la variable
            //libro.AgregarValoracion(2);

            // Creamos otro objeto de clase
            LibroValoraciones libro2 = libro; // Si se hace esta igualación, van a compartir el mismo espacio de memoria. Libro2 termina pisando a Libro con los datos de ambos
            libro2.AgregarValoracion(2); // Libro2 toma todas las propiedades de libro mas el nuevo dato
        }
    }
}
