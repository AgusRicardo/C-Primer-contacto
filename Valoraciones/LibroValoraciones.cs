using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    internal class LibroValoraciones
    {
        //public static string nombre = "Agustin";
        List<float> valoraciones;

        // Creamos métodos y constructores
        public LibroValoraciones()
        {
            valoraciones = new List<float>(); // List es una clase de Collections.Generic que permite almacenar datos en lista.
        }

        public CalcularValoraciones PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0;
            foreach (float valoracion in valoraciones)
            {
                calculo.valoracionMinima = Math.Min(valoracion, calculo.valoracionMinima); // Al inicio valoracionMinima está en nulo pero despues se va ir pisando y te vas quedando con la minima
                calculo.valoracionMaxima = Math.Max(valoracion, calculo.valoracionMaxima);
                sumaValoraciones += valoracion; // Incrementamos la suma total de valoraciones
            }

            calculo.promedioValoraciones = sumaValoraciones / valoraciones.Count; // Se calula el promedio dividiendo por la cant total de valoraciones
            return calculo;
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion); // Agregamos la valoracion que reciba a la lista de valoraciones
        }
    }
}
