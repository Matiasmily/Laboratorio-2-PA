﻿using System;
using System.Collections.Concurrent;
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
        public void IngresarHabitacion(List<Habitacion> listaHabitaciones)
        {
            int numero;
            double precio;
            bool tieneJacuzi = false;
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
                            Console.Clear();
                            Console.WriteLine("--- HABITACIÓN SIMPLE ---");
                            Console.Write("Numero: ");
                            numero = int.Parse(Console.ReadLine()??"");
                            Console.Write("Precio: ");
                            precio = double.Parse(Console.ReadLine() ?? "");
                            Console.Write("Número de Camas: ");
                            int numeroCamas = int.Parse(Console.ReadLine() ?? "");
                            Simple habitacionSimple = new Simple(numero, precio, true , "No hay cliente asignado", numeroCamas);
                            listaHabitaciones.Add(habitacionSimple);
                            Console.WriteLine("\nHabitación Simple agregada con éxito");
                            Enter();
                            menuHabitacion = false;
                            break;
                        case 2:
                            Console.Clear();
                            bool vistaAlMar = false;
                            Console.WriteLine("--- HABITACIÓN DOBLE ---");
                            Console.Write("Numero: ");
                            numero = int.Parse(Console.ReadLine() ?? "");
                            Console.Write("Precio: ");
                            precio = double.Parse(Console.ReadLine() ?? "");
                            Console.Write("Vista al Mar (Si/No): ");
                            string vista = Console.ReadLine() ?? "".ToUpper();
                            if (vista == "Si")
                            {
                                 vistaAlMar = true;
                            }
                            else
                            {
                                vistaAlMar = false;
                            }
                            Doble habitacionDoble = new Doble(numero, precio, true, "No hay cliente asignado", vistaAlMar);
                            listaHabitaciones.Add((habitacionDoble));
                            Console.WriteLine("\nHabitación Doble agregada con éxito");
                            Enter();
                            menuHabitacion = false;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("--- SUITES ---");
                            Console.Write("Numero: ");
                            numero = int.Parse(Console.ReadLine() ?? "");
                            Console.Write("Precio: ");
                            precio = double.Parse(Console.ReadLine() ?? "");
                            Console.Write("Número de Habitaciones: ");
                            int numeroHabitaciones = int.Parse(Console.ReadLine() ?? "");
                            Console.Write("Jacuzzi (Si/No): ");
                            string jacuzzi = Console.ReadLine() ?? "".ToUpper();
                            if (jacuzzi == "Si")
                            {
                                tieneJacuzi = true;
                            }
                            else
                            {
                                tieneJacuzi = false;
                            }
                            Suite habitacionSuite = new Suite(numero, precio,true, "No hay cliente asignado", numeroHabitaciones, tieneJacuzi);
                            listaHabitaciones.Add(habitacionSuite);
                            Console.WriteLine("\nSuite Agregada con éxito");
                            Enter();
                            menuHabitacion = false;
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("--- HABITACIÓN DELUXE ---");
                            Console.Write("Numero: ");
                            numero = int.Parse(Console.ReadLine() ?? "");
                            Console.Write("Precio: ");
                            precio = double.Parse(Console.ReadLine() ?? "");
                            Console.Write("Servicios extras: ");
                            string servicios =Console.ReadLine() ?? "";
                            Deluxe habitacionDeluxe = new Deluxe(numero, precio, true, "No hay cliente asignado", servicios);
                            listaHabitaciones.Add(habitacionDeluxe);
                            Console.WriteLine("\nHabitación Deluxe agregada con éxito");
                            Enter();
                            menuHabitacion = false;
                            break;
                        case 5:

                            break;
                        default:
                            Console.WriteLine("\nIngrese una opción válida");
                            menuHabitacion = false;
                            Enter();
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
        public void Enter()
        {
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();  
        }

        public void MostrarInformacion(List <Habitacion> listaHabitaciones)
        {
            Console.Clear();
            Console.WriteLine("--- MOSTRAR INFORMACIÓN --- ");
            foreach (Habitacion habitaciones in listaHabitaciones)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                habitaciones.MostrarInformacionHabitacion();
            }

        }
        public virtual void MostrarInformacionHabitacion()
        {
            Console.WriteLine($"Numero: {Numero}\nPrecio Por Noche: {PrecioPorNoche}\nDisponibilidad: {Disponible}\nCliente: {ClienteAsignado}");

        }
        public void AsignarCliente(List<Habitacion> listaHabitaciones)
        {
            Console.Clear();
            Console.WriteLine("--- ASIGNAR HABITACIÓN ---");
            Console.Write("Ingrese el número de habitación que desea: ");
            int numeroHabitacion = int.Parse(Console.ReadLine()??"");
            Console.Write("Nombre del Cliente: ");
            string nombreCliente = Console.ReadLine()??"";
            Habitacion? buscarHabitacion = listaHabitaciones.Find(x=>x.Numero == numeroHabitacion && x.Disponible == true);
            if ( buscarHabitacion != null)
            {
                buscarHabitacion.Disponible = false;
                buscarHabitacion.ClienteAsignado = nombreCliente;
                Console.WriteLine("\nHabitación asignada correctamente");
                Enter();
            }
            else
            {
                Console.WriteLine("No se ha encontrado la habitación o no está disponible");
                Enter();
            }
           
        }
        public void LiberarHabitacion(List<Habitacion> listaHabitaciones)
        {
            Console.Clear();
            Console.WriteLine("--- LIBERAR HABITACIÓN ---");
            Console.Write("Ingrese el número de habitación que desea liberar: ");
            int numeroHabitacion = int.Parse(Console.ReadLine() ?? "");
            Habitacion? buscarHabitacion = listaHabitaciones.Find(x => x.Numero == numeroHabitacion && x.Disponible == false);
            if (buscarHabitacion != null)
            {
                buscarHabitacion.Disponible = true;
                buscarHabitacion.ClienteAsignado = "No hay cliente asignado";
                Console.WriteLine("\nLa Habitación ha sido liberada");
                Enter();
            }
            else
            {
                Console.WriteLine("No se ha encontrado la habitación o se encuentra libre");
                Enter();
            }
        }
        public void EliminarHabitacion(List<Habitacion> listaHabitaciones)
        {
            Console.Clear();
            Console.WriteLine("--- ELIMINAR HABITACIÓN ---");
            Console.Write("Ingrese el número de habitación que desea eliminar: ");
            int numeroHabitacion = int.Parse(Console.ReadLine() ?? "");
            Habitacion? buscarHabitacion = listaHabitaciones.Find(x => x.Numero == numeroHabitacion);
            if (buscarHabitacion != null)
            {
                listaHabitaciones.Remove(buscarHabitacion);
                Console.WriteLine("\nLa Habitación ha sido eliminada");
                Enter();
            }
            else
            {
                Console.WriteLine("No se ha encontrado la habitación");
                Enter();
            }
        }

    }
}
