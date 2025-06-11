using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2_servicio
{
    internal class Servicio
    {
        #region declaracion
        public int Edad1, Edad2, Edad3, Edad0;
        public double Monto, Porcentaje0, Porcentaje1, Porcentaje2, Porcentaje3, Monto0, Monto1, Monto2, Monto3;
        #endregion
        public Servicio()
        {
            Edad1 = 0; Edad2 = 0; Edad3 = 0; Edad0=0; Monto = 0; Porcentaje0 = 0; Porcentaje1 = 0; Porcentaje2 = 0; Porcentaje3 = 0; Monto0 = 0; Monto1 = 0; Monto2 = 0; Monto3=0;
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
            double edades = Edad0 + Edad1 + Edad2 + Edad3;
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
