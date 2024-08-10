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
            NumeroDeCamas = numerodeCamas;
        }

        public int NumeroDeCamas { get; set; }
        public override void MostrarInformacionHabitacion()
        {
            string tipo = "Simple";
            base.MostrarInformacionHabitacion();
            Console.WriteLine($"Número de camas: {NumeroDeCamas}\nTipo de Habitación:{tipo}");
            Console.WriteLine("--------------------------------------------------------------------------------");
          
        }

    }
   
}
