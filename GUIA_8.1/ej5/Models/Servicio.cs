using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ej5.Models
{
    internal class Servicio
    {
        public int DeterminarLosDiasDelMes(int año, int mes)
        {
            int dias = 0;
            if (mes <= 7 && mes > 0)
            {
                bool bisiesto = DeterminarSiEsBisiesto(año);
                if (mes % 2 == 0)
                {
                    dias = 30;
                    if (mes == 2)
                    {
                        dias = 28;
                        if (bisiesto == true)
                        {
                            dias = 29;
                        }
                    }
                }
                else
                {
                    dias = 31;
                }
            }
            else if (mes <= 12)
            {
                if (mes % 2 == 0)
                {
                    dias = 31;
                }
                else
                {
                    dias = 30;
                }
            }
                return dias;
        }
        public bool DeterminarSiEsBisiesto(int año)
        {
            bool EsBisiesto = false;
            if (año % 4 == 0)
            {
                if (año % 100 != 0 || año % 400 == 0)
                {
                    EsBisiesto = true;
                }
            }
            return EsBisiesto;
        }
    }
}
