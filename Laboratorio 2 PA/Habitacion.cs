using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_PA
{
    public class Habitacion
    {
        public int Numero {  get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }
        
        public Habitacion(List<Habitacion> listaHabitaciones) { }
        public Habitacion(int numero, double precioPorNoche, bool disponible, string clienteAsignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponible = disponible;
            ClienteAsignado = clienteAsignado;
        }
        public void AgregarDatosHabitacion(List<Habitacion> listaHabitaciones)
        {
            Console.Write("Numero: ");
            string numero = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());
        }
        public void IngresarHabitacion(List<Habitacion> listaHabitaciones)
        {
            Console.WriteLine("--- AGREGAR HABITACIÓN ---");
            MenuHabitación();
            int opcionHabitacion = int.Parse(Console.ReadLine()??"");
            bool menuHabitacion = true;
            do
            {
                try
                {
                    switch(opcionHabitacion)
                    {
                        case 1:
                            Console.WriteLine("--- HABITACIÓN SIMPLE ---");
                            AgregarDatosHabitacion(listaHabitaciones);
                            menuHabitacion = false;
                            break;
                        case 2:
                            Console.WriteLine("--- HABITACIÓN DOBLE ---");
                            AgregarDatosHabitacion(listaHabitaciones);
                            menuHabitacion = false;
                            break;
                        case 3:
                            Console.WriteLine("--- SUITES ---");
                            AgregarDatosHabitacion(listaHabitaciones);
                            menuHabitacion = false;
                            break;
                        case 4:
                            Console.WriteLine("--- HABITACIÓN DELUXE ---");
                            AgregarDatosHabitacion(listaHabitaciones);
                            menuHabitacion = false;
                            break;

                    }

                }
                catch (FormatException)
                {

                }
            } while (menuHabitacion);
        }

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("--- HOTEL BUENA VISTA ---");
            Console.WriteLine("1. Agregar habitación");
            Console.WriteLine("2. Eliminar Habitación");
            Console.WriteLine("3. Mostrar Habitaciones");
            Console.WriteLine("4. Asignar Habitación al Cliente");
            Console.WriteLine("5. Liberar Habitación");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese una opción: ");
        }
        public void MenuHabitación()
        {
            Console.Clear();
            Console.WriteLine("--- MENÚ HABITACIONES ---");
            Console.WriteLine("1. Habitación Simple");
            Console.WriteLine("2. Habitación Doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Habitación Deluxe");
            Console.WriteLine("5. Regresar al menú anterior");
            Console.Write("Ingrese una opción: ");
        }
    }
}
