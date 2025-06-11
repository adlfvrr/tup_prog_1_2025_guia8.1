using ej4.Models;
namespace ej4
{
    internal class Program
    {
        static private Servicio servicio = new Servicio();
        static private int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese una opción: \n1.Registrar nombres de jugadores\n2.Registrar resultado de cada set\n3.Mostrar ganador\nOtro.Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static private void MostrarPantallaSolicitarNombreJugadores()
        {
            servicio.RegistrarJugadores();
        }
        static private void MostrarPantallaSolicitarResultadoSet()
        {
            servicio.RegistrarResultadoSet();
        }
        static private void MostrarPantallaGanador()
        {
            string ganador = servicio.DeterminarGanador();
            if (ganador != "")
            {
                Console.WriteLine($"El ganador del partido es {ganador}");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                int op = MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                    case 1: MostrarPantallaSolicitarNombreJugadores(); break;
                    case 2: MostrarPantallaSolicitarResultadoSet(); break;
                    case 3: MostrarPantallaGanador(); break;
                    default: menu = false; break;
                }
            }
        }
    }
}
