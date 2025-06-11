using ej3_servicio;
namespace ej3
{
    internal class Program
    {
        static private Servicio servicio = new Servicio();
        static private int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese opción: \n1.Registrar numeros de libreta\n2.Mostrar lista ordenada\nOtro.Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static private void MostrarPantallaSolicitarAlumnos()
        {
            servicio.RegistrarNombreYNumeroLibreta();
        }
        static private void MostrarPantallaMostrarListaOrdenada()
        {
            if (servicio.NumeroLibreta0 > servicio.NumeroLibreta1)
            {
                if (servicio.NumeroLibreta0 > servicio.NumeroLibreta2)
                {
                    if (servicio.NumeroLibreta1 > servicio.NumeroLibreta2)
                    {
                        Console.WriteLine(@$"El alumno con mayor numero es {servicio.Nombre0} con el numero {servicio.NumeroLibreta0}
El alumno con numero medio es {servicio.Nombre1} con la nota {servicio.NumeroLibreta1}
El alumno con menor numero es {servicio.Nombre2} con el numero {servicio.NumeroLibreta2}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(@$"El alumno con mayor numero es {servicio.Nombre0} con el numero {servicio.NumeroLibreta0}
El alumno con numero medio es {servicio.Nombre2} con la nota {servicio.NumeroLibreta2}
El alumno con menor numero es {servicio.Nombre1} con el numero {servicio.NumeroLibreta1}");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine(@$"El alumno con mayor numero es {servicio.Nombre2} con el numero {servicio.NumeroLibreta2}
El alumno con numero medio es {servicio.Nombre0} con la nota {servicio.NumeroLibreta0}
El alumno con menor numero es {servicio.Nombre1} con el numero {servicio.NumeroLibreta1}");
                    Console.ReadKey();
                }
            }
            else
            {
                if (servicio.NumeroLibreta1 > servicio.NumeroLibreta2)
                {
                    if (servicio.NumeroLibreta2 > servicio.NumeroLibreta0)
                    {
                        Console.WriteLine(@$"El alumno con mayor numero es {servicio.Nombre1} con el numero {servicio.NumeroLibreta1}
El alumno con numero medio es {servicio.Nombre2} con la nota {servicio.NumeroLibreta2}
El alumno con menor numero es {servicio.Nombre0} con el numero {servicio.NumeroLibreta0}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(@$"El alumno con mayor numero es {servicio.Nombre1} con el numero {servicio.NumeroLibreta1}
El alumno con numero medio es {servicio.Nombre0} con la nota {servicio.NumeroLibreta0}
El alumno con menor numero es {servicio.Nombre2} con el numero {servicio.NumeroLibreta2}");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine(@$"El alumno con mayor numero es {servicio.Nombre2} con el numero {servicio.NumeroLibreta2}
El alumno con numero medio es {servicio.Nombre1} con la nota {servicio.NumeroLibreta1}
El alumno con menor numero es {servicio.Nombre0} con el numero {servicio.NumeroLibreta0}");
                    Console.ReadKey();
                }
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
                    case 1: MostrarPantallaSolicitarAlumnos(); break;
                    case 2: MostrarPantallaMostrarListaOrdenada(); break;
                    default: menu = !menu; break;
                }
            }
        }
    }
}
    

