using ej7.Models;
namespace ej7
{
    internal class Program
    {
        private static Servicio servicio = new Servicio();
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            {
                Console.Clear();
                Console.WriteLine(@"Ingrese opción: 
1- Ingresar un resumen de venta.
2- Mostrar Número de transacción registrado con el mayor monto total.
3- Mostrar porcentaje de cantidad por rubro.
4- Mostrar la recaudación total.
Otro- Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                return opcion;
            }
        }
        private static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Write("Ingrese numero de transacción: ");
            int nroTransaccion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese rubro: ");
            int rubro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese monto: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            servicio.EvaluarTransaccionPuntoDeVenta(nroTransaccion, rubro, cantidad, monto);
        }
        private static void MostrarPantallaPorcentajeDeCantidadesPorRubro(int contadorDeTransacciones)
        {
            if (contadorDeTransacciones > 0)
            {
                servicio.CalcularPorcentajesCantidadVentasPorRubro(contadorDeTransacciones);
                Console.WriteLine(@$"Los porcentajes de cantidad por rubro son:
Rubro 1: {servicio.PorcentajeCantidadRubro1:f2}%
Rubro 2: {servicio.PorcentajeCantidadRubro2:f2}%
Rubro 3: {servicio.PorcentajeCantidadRubro3:f2}%
Rubro 4: {servicio.PorcentajeCantidadRubro4:f2}%
Rubro 5: {servicio.PorcentajeCantidadRubro5:f2}%");
                Console.ReadKey();
            }
            else { Console.WriteLine("No hubo transacciones."); Console.ReadKey(); }
        }
        private static void MostrarPantallaTransaccionMayorMonto(int contadorDeTransacciones)
        {
            if (contadorDeTransacciones > 0)
            {
                Console.WriteLine($"La transaccion con mayor monto es la numero {servicio.NumeroTransaccionMayor}, con un monto de ${servicio.MontoTransaccionMayor:f2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hubo transacciones.");
                Console.ReadKey();
            }
        }
        private static void MostrarPantallaMontoRecaudadoTotal(int contadorDeTransacciones)
        {
            if (contadorDeTransacciones > 0)
            {
                Console.WriteLine($"La recaudación total es de ${servicio.RecaudacionTotal:f2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hubo transacciones");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int contadorDeTransacciones = 0;
            bool menu = true;
            while (menu)
            {
                int op = MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                    case 1: MostrarPantallaRegistrarTransaccion(); contadorDeTransacciones++; break;
                    case 2: MostrarPantallaTransaccionMayorMonto(contadorDeTransacciones); break;
                    case 3: MostrarPantallaPorcentajeDeCantidadesPorRubro(contadorDeTransacciones); break;
                    case 4: MostrarPantallaMontoRecaudadoTotal(contadorDeTransacciones); break;
                    default: menu = false; break;
                }

            }
        }
    }
}
