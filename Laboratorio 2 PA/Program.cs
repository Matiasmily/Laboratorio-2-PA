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
                break;
            case 3:
                objetoHabitacion.MostrarInformacion(habitaciones);
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            default:
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
