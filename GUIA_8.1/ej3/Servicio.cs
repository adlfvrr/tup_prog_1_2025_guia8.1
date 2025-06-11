using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ej3_servicio
{
    internal class Servicio
    {
        public string Nombre0, Nombre1, Nombre2;
        public int NumeroLibreta0, NumeroLibreta1, NumeroLibreta2;
        private int Orden;
        public Servicio()
        {
            Nombre0 = ""; Nombre1 = ""; Nombre2 = ""; NumeroLibreta0 = 0; NumeroLibreta1 = 0; NumeroLibreta2 = 0; Orden = 0;
        }
        public void RegistrarNombreYNumeroLibreta()
        {
            if (Orden < 4)
            {
                Console.Write($"Ingrese nombre del alumno {Orden + 1}: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese número de libreta: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (Nombre0 == "" && NumeroLibreta0 == 0)
                {
                    Nombre0 = nombre;
                    NumeroLibreta0 = numero;
                }
                else if (Nombre1 == "" && NumeroLibreta1 == 0)
                {
                    Nombre1 = nombre;
                    NumeroLibreta1 = numero;
                }
                else if (Nombre2 == "" && NumeroLibreta2 == 0)
                {
                    Nombre2 = nombre;
                    NumeroLibreta2 = numero;
                }
                Orden++;
            }
            else
            {
                Console.WriteLine("Límite de ingresos alcanzado.");
                Console.ReadKey();
            }
        }
    }
}
