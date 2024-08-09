using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_PA
{
    public class Doble : Habitacion
    {
        public Doble(int numero,double precioPorNoche, bool disponible, string clienteAsignado, bool vistaAlMar) : base(numero,  precioPorNoche, disponible, clienteAsignado)
        {
        }

        public bool VistaAlMar {  get; set; }

    }
}
