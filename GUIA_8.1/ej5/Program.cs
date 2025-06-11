using System.Numerics;
using ej5.Models;
namespace ej5
{
    internal class Program
    {
        private static Servicio servicio = new Servicio();
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Ingrese opción:
1. Determinar cantidad de días del mes
2. Verificar si el año es bisiesto.
Otro. Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        private static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            int mes, año;
            Console.Write("Ingrese mes(1-12): ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese año: ");
            año = Convert.ToInt32(Console.ReadLine());
            int dias = servicio.DeterminarLosDiasDelMes(año, mes);
            if (dias > 0)
            {
                Console.WriteLine($"Los días del mes {mes} son {dias}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Mes o año inválidos");
                Console.ReadKey();
            }
        }
        private static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Write("Ingrese año: ");
            int año = Convert.ToInt32(Console.ReadLine());
            bool EsBisiesto = servicio.DeterminarSiEsBisiesto(año);
            if (EsBisiesto == true)
            {
                Console.WriteLine("El año es bisiesto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                int opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarMesAñoYDeterminarDias(); break;
                    case 2: MostrarPantallaVerificarSiElAñoEsBisiesto(); break;
                    default: menu = false; break;
                }
            }
        }
    }
}
