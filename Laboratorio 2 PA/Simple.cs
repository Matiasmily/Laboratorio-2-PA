using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_PA
{
    public class Simple : Habitacion
    {
        

        public Simple(int numero, double precioPorNoche, bool disponible, string clienteAsignado, int numerodeCamas) : base(numero, precioPorNoche, disponible, clienteAsignado)
        {
        }

        public int NumeroDeCamas { get; set; }

    }
}
