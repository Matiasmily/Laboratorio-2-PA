using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_PA
{
    public class Suite : Habitacion
    {
        public Suite(int numero, double precioPorNoche, bool disponible, string clienteAsignado, int numeroDeHabitaciones, bool tieneJacuzzi) : base(numero, precioPorNoche, disponible, clienteAsignado)
        {
        }

        public int NumerodeHabitaciones { get; set; }
        public bool TieneJacuzzi {  get; set; } 

    }
}
