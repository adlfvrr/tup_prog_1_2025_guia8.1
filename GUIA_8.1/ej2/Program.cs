using System.Threading;

namespace ej2
{
    internal class Program
    {
       static private Servicio servicio = new Servicio();
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
            if (servicio.suma <= 0)
            {
                servicio.CalcularMontosYPorcentajesARepartir();
                Console.WriteLine($"A la niña 1 le corresponde un {servicio.por0:f2}%, equivalente a ${m0:f2}");
                Console.WriteLine($"A la niña 2 le corresponde un {por1:f2}%, equivalente a ${m1:f2}");
                Console.WriteLine($"A la niña 3 le corresponde un {por2:f2}%, equivalente a ${m2:f2}");
                Console.WriteLine($"A la niña 4 le corresponde un {por3:f2}%, equivalente a ${m3:f2}");
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
    internal class Servicio
    {
        #region declaracion
        static public int e1, e2, e3, e0,suma; 
        static public double monto, por0, por1, por2, por3, m0, m1, m2, m3;
        #endregion
       public Servicio()
        {
            suma = 0; e0 = 0; e1 = 0; e2 = 0; e3 = 0; monto = 0; m0 = 0; m1 = 0; m2 = 0; m3 = 0;
            por0 = 0; por1 = 0; por2 = 0; por3 = 0;
        }
        public double RegistrarMontoARepartir()
        {
            Console.Write("Ingrese el monto a repartir: $");
            monto = Convert.ToDouble(Console.ReadLine());
            return monto;
        }
        public void RegistrarEdad()
        {
            int edad = 0;
            Console.Write("Ingrese edad de la niña: ");
            edad = Convert.ToInt32(Console.ReadLine());
            suma += edad;
            Console.Write("A qué niña corresponde? ");
            int nroNina = Convert.ToInt32(Console.ReadLine());
            if (nroNina == 1)
            {
                e0 = edad;
            }
            else if (nroNina == 2)
            {
                e1 = edad;
            }
            else if (nroNina == 3)
            {
                e2 = edad;
            }
            else if (nroNina == 4)
            {
                e3 = edad;
            }
        }
        public void CalcularMontosYPorcentajesARepartir()
        {
            por0 = 1.0 * (e0 / (double)suma) * 100;
            por1 = 1.0 * (e1 / (double)suma) * 100;
            por2 = 1.0 * (e2 / (double)suma) * 100;
            por3 = 1.0 * (e3 / (double)suma) * 100;
            m0 = (por0 * monto) / 100;
            m1 = (por1 * monto) / 100;
            m2 = (por2 * monto) / 100;
            m3 = (por3 * monto) / 100;
        }
    }
}
