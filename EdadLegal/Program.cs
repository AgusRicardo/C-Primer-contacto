
using System;
namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre y pulse enter: ");
            string nombre = Console.ReadLine();

            if (nombre == "")
            {
                Console.WriteLine("Nombre no está definidos");
                return;
            }
            Console.WriteLine("Escriba su edad y pulse enter: ");
            int edad = int.Parse(Console.ReadLine()); // Como de la consola viene tipo string, lo convertimos a entero
            
            
            if (edad >= 18 )
            {
                Console.WriteLine(nombre + " tenés " + edad + " y legalmente sos mayor de edad." );
            }else
            {
                Console.WriteLine(nombre + " tenés " + edad + " y legalmente sos menor de edad.");
            }

        }
    }
}
