using System.Threading;
using ej2_servicio;

namespace ej2
{
    internal class Program
    {
       static Servicio servicio = new Servicio();
        static private int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese opción:\n1. Iniciar monto a repartir\n2. Solicitar edad por niña\n3. Mostrar monto y porcentajes que corresponde a cada niña.\nOtro. Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static private void MostrarPantallaSolicitarMontoARepartir()
        {
            servicio.RegistrarMontoARepartir();
        }
        static private void MostrarPantallaSolicitarEdadesNiñas()
        {
            servicio.RegistrarEdad();
        }
        static private void MostrarPantallaCalcularYMostrarMontoYPorcentajePorNiña()
        {
            if ((servicio.Edad0 + servicio.Edad1 + servicio.Edad2 + servicio.Edad3) > 0)
            {
                servicio.CalcularMontosYPorcentajesARepartir();
                Console.WriteLine($"A la niña 1 le corresponde un {servicio.Porcentaje0:f2}%, equivalente a ${servicio.Monto0:f2}");
                Console.WriteLine($"A la niña 2 le corresponde un {servicio.Porcentaje1:f2}%, equivalente a ${servicio.Monto1:f2}");
                Console.WriteLine($"A la niña 3 le corresponde un {servicio.Porcentaje2:f2}%, equivalente a ${servicio.Monto2:f2}");
                Console.WriteLine($"A la niña 4 le corresponde un {servicio.Porcentaje3:f2}%, equivalente a ${servicio.Monto3:f2}");
                Console.ReadKey();
            }
            else { Console.WriteLine("No se ingresaron edades."); Console.ReadKey(); }
        }
        static void Main(string[] args)
        {
            bool seguir = true;
            while (seguir)
            {
                int op = MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                    case 1: MostrarPantallaSolicitarMontoARepartir(); break;
                    case 2: MostrarPantallaSolicitarEdadesNiñas(); break;
                    case 3: MostrarPantallaCalcularYMostrarMontoYPorcentajePorNiña(); break;
                    default: seguir = !seguir; break;

                }
            }
        }
    }
}
