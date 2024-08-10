// See https://aka.ms/new-console-template for more information
using Laboratorio_2_PA;
using System.ComponentModel.Design;

List <Habitacion> habitaciones = new List <Habitacion> ();
Habitacion objetoHabitacion = new Habitacion(habitaciones);

bool menu = true;

do
{
    try
    {
        objetoHabitacion.MostrarMenu();
        int opcion = int.Parse(Console.ReadLine()??"");
        switch (opcion)
        {
            case 1:
                objetoHabitacion.IngresarHabitacion(habitaciones);
                break;
            case 2:
                objetoHabitacion.EliminarHabitacion(habitaciones);
                break;
            case 3:
                objetoHabitacion.MostrarInformacion(habitaciones);
                objetoHabitacion.Enter();
                break;
            case 4:
                objetoHabitacion.AsignarCliente(habitaciones);
                break;
            case 5:
                objetoHabitacion.LiberarHabitacion(habitaciones);
                break;
            case 6:
                Console.WriteLine("\nUsted está saliendo del programa...");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                menu = false;
                break;
            default:
                Console.WriteLine("\nIngrese una opción válida");
                objetoHabitacion.Enter();
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese una opción válida..");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
    }


}while(menu);

