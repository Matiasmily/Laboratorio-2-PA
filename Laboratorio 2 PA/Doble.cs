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
            VistaAlMar = vistaAlMar;
        }

        public bool VistaAlMar {  get; set; }

        public override void MostrarInformacionHabitacion()
        {
            string tipo = "Doble";
            base.MostrarInformacionHabitacion();
            Console.WriteLine($"Vista al Mar: {VistaAlMar}\nTipo de Habitación:{tipo}");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
