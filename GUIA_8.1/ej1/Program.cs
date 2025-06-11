using static System.Net.Mime.MediaTypeNames;

namespace ej1
{
    public class Program
    {
        private Servicio servicio;
        public Program()
        {
         servicio = new Servicio();
        }
        public void SolicitarNumero()
        {
            Console.Write("Ingrese un número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(n);
        }
        public void SolicitarVariosNumeros()
        {
            Console.Write("Ingrese cantidad de ingresos: ");
            int ingresos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ingresos; i++)
            {
                Console.Write("Ingrese un número: ");
                int n = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarValor(n);
            }
        }
        private void IniciarVariables()
        {
            servicio.ReiniciarVariables();
            Console.WriteLine("Variables reinicadas");
            Console.ReadKey();
        }
        private static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese opción: \n1.Solicitar número\n2.Solicitar varios números\n3.Mostrar máximo y mínimo\n4.Mostrar promedio\n5.Cantidad de numeros ingresados\n6.Iniciar Variables\nOtro.Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        private void MostrarMaximoYMinimo()
        {
            Console.WriteLine($"El numero mayor ingresado es {servicio.max}.\nEl numero menor ingresado es {servicio.min}.");
            Console.ReadKey();
        }
        private void MostrarPromedio()
        {
            if (servicio.cont != 0)
            {
                double prom = servicio.CalcularPromedio();
                Console.WriteLine($"El promedio es {prom:f2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
                Console.ReadKey();
            }
        }
        private void MostrarCantidadNumeros()
        {
            Console.WriteLine($"Los numeros ingresados son {servicio.cont}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program servicios = new Program();
            bool menu = true;
            int opcion;
            while (menu)
            {

                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: servicios.SolicitarNumero(); break;
                    case 2: servicios.SolicitarVariosNumeros(); break;
                    case 3: servicios.MostrarMaximoYMinimo(); break;
                    case 4: servicios.MostrarPromedio(); break;
                    case 5: servicios.MostrarCantidadNumeros(); break;
                    case 6: servicios.IniciarVariables(); break;
                    default: menu = false; break;
                }

            }

        }
    }
    public class Servicio
    {
         private int ac;
         public int cont, min, max;
        public Servicio()
        {
            ac = 0; cont = 0; max = 0; min = 0;
        }
        public void RegistrarValor(int n)
        {
            ac += n;
            cont++;
            if (max == 0 && min == 0)
            {
                max = n;
                min = n;
            }
            else
            {
                if (n > max)
                {
                    max = n;
                }
                else if (n < min)
                {
                    min = n;
                }
            }
        }
        public double CalcularPromedio()
        {
            double prom = 1.0 * (ac / (double)cont);
            return prom;
        }
        public void ReiniciarVariables()
        {
            ac = 0;
            cont = 0;
            min = 0;
            max = 0;
        }
    
    } 
}