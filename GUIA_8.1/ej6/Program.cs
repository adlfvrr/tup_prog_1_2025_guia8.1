using ej6.Models;
namespace ej6
{
    internal class Program
    {
        private static Servicio servicio = new Servicio();
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Ingrese opcion:
1. Registrar opinión.
2. Procesar y mostrar resultados encuesta.
Otro. Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        private static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Write("Ingrese opinión: 0.Positivo - 1.Negativo - 2.Indeciso ");
            int opinion = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarOpinion(opinion);
        }
        private static void MostrarPantallaProcesarYMostrarResultadosEncuesta(int encuestados)
        {
            if (encuestados > 0)
            {
                servicio.ProcesarEncuesta(encuestados);
                Console.WriteLine(@$"Los resultados de la encuesta son:
Positivos - {servicio.PorcentajePositivos:f2}%
Negativos - {servicio.PorcentajeNegativos:f2}%
Indecisos - {servicio.PorcentajeIndecisos:f2}%");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hubo encuestados.");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int encuestados = 0;
            bool menu = true;
            while (menu)
            {
                int opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaRegistrarEncuesta();encuestados++; break;
                    case 2: MostrarPantallaProcesarYMostrarResultadosEncuesta(encuestados); break;
                    default: menu = false; break;
                }
            }
        }
    }
}
