using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    internal class LibroValoraciones
    {
        List<float> valoraciones;
     
        // Creamos métodos y constructores
        public LibroValoraciones()
        {
            valoraciones = new List<float>(); // List es una clase de Collections.Generic que permite almacenar datos en lista.
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion); // Agregamos la valoracion que reciba a la lista de valoraciones
        }
    }
}
