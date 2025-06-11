using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej6.Models
{
    internal class Servicio
    {
        private int indecisos, negativos, positivos;
        public double PorcentajeIndecisos, PorcentajeNegativos, PorcentajePositivos;
        public Servicio()
        {
            indecisos = 0; negativos = 0; positivos = 0;
            PorcentajeIndecisos = 0;
            PorcentajeNegativos = 0;
            PorcentajePositivos = 0;
        }
        public void RegistrarOpinion(int opinion)
        {
            if (opinion == 0)
            {
                positivos++;
            }
            else if (opinion == 1)
            {
                negativos++;
            }
            else if (opinion == 2)
            {
                indecisos++;
            }
        }
        public void ProcesarEncuesta(int encuestados)
        {
            PorcentajeIndecisos = 1.0 * (indecisos / (double)encuestados) * 100;
            PorcentajeNegativos = 1.0 * (negativos / (double)encuestados) * 100;
            PorcentajePositivos = 1.0 * (positivos / (double)encuestados) * 100;
        }
    }
}
