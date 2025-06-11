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
            if ((servicio.Edad0 + servicio.Edad1 + servicio.Edad2 + servicio.Edad3) > 0)
            {
                servicio.CalcularMontosYPorcentajesARepartir();
                Console.WriteLine($"A la niña 1 le corresponde un {servicio.Porcentaje0:f2}%, equivalente a ${Monto0:f2}");
                Console.WriteLine($"A la niña 2 le corresponde un {Porcentaje1:f2}%, equivalente a ${Monto1:f2}");
                Console.WriteLine($"A la niña 3 le corresponde un {Porcentaje2:f2}%, equivalente a ${Monto2:f2}");
                Console.WriteLine($"A la niña 4 le corresponde un {Porcentaje3:f2}%, equivalente a ${Monto3:f2}");
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
        static public int Edad1, Edad2, Edad3, Edad0; 
        static public double Monto, Porcentaje0, Porcentaje1, Porcentaje2, Porcentaje3, Monto0, Monto1, Monto2, Monto3;
        #endregion
       public Servicio()
        {
            Edad0 = 0; Edad1 = 0; Edad2 = 0; Edad3 = 0; Monto = 0; Monto0 = 0; Monto1 = 0; Monto2 = 0; Monto3 = 0;
            Porcentaje0 = 0; Porcentaje1 = 0; Porcentaje2 = 0; Porcentaje3 = 0;
        }
        public double RegistrarMontoARepartir()
        {
            Console.Write("Ingrese el monto a repartir: $");
            Monto = Convert.ToDouble(Console.ReadLine());
            return Monto;
        }
        public void RegistrarEdad()
        {
            int edad = 0;
            Console.Write("Ingrese edad de la niña: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("A qué niña corresponde? ");
            int nroNina = Convert.ToInt32(Console.ReadLine());
            if (nroNina == 1)
            {
                Edad0 = edad;
            }
            else if (nroNina == 2)
            {
                Edad1 = edad;
            }
            else if (nroNina == 3)
            {
                Edad2 = edad;
            }
            else if (nroNina == 4)
            {
                Edad3 = edad;
            }
        }
        public void CalcularMontosYPorcentajesARepartir()
        {
            Porcentaje0 = 1.0 * (Edad0 / (double)Edad0 + Edad1 + Edad2 + Edad3) * 100;
            Porcentaje1 = 1.0 * (Edad1 / (double)Edad0 + Edad1 + Edad2 + Edad3) * 100;
            Porcentaje2 = 1.0 * (Edad2 / (double)Edad0 + Edad1 + Edad2 + Edad3) * 100;
            Porcentaje3 = 1.0 * (Edad3 / (double)Edad0 + Edad1 + Edad2 + Edad3) * 100;
            Monto0 = (Porcentaje0 * Monto) / 100;
            Monto1 = (Porcentaje1 * Monto) / 100;
            Monto2 = (Porcentaje2 * Monto) / 100;
            Monto3 = (Porcentaje3 * Monto) / 100;
        }
    }
}
