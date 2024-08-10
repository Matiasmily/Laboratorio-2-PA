using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_PA
{
    public class Deluxe : Habitacion
    {
        public Deluxe(int numero, double precioPorNoche, bool disponible, string clienteAsignado, string serviciosExtras) : base(numero, precioPorNoche, disponible, clienteAsignado)
        {
            ServiciosExtras = serviciosExtras;
        }

        public string ServiciosExtras { get; set; }

        public override void MostrarInformacionHabitacion()
        {
            string tipo = "Deluxe";
            base.MostrarInformacionHabitacion();
            Console.WriteLine($"Servicios Extras: {ServiciosExtras}\nTipo de Habitación:{tipo}");
            Console.WriteLine("--------------------------------------------------------------------------------");
            
        }
    }
}
