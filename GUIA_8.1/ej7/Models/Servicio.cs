using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej7.Models
{
    internal class Servicio
    {
        private int cantidad1, cantidad2, cantidad3, cantidad4, cantidad5, contadorDeTransacciones;
        public int NumeroTransaccionMayor;
        public double MontoTransaccionMayor, PorcentajeCantidadRubro1, PorcentajeCantidadRubro2, PorcentajeCantidadRubro3, PorcentajeCantidadRubro4, PorcentajeCantidadRubro5, RecaudacionTotal;
        public Servicio()
        {
            cantidad1 = 0; cantidad2 = 0; cantidad3 = 0; cantidad4= 0; cantidad5= 0; contadorDeTransacciones = 0; NumeroTransaccionMayor = 0; MontoTransaccionMayor= 0;PorcentajeCantidadRubro1 = 0; PorcentajeCantidadRubro2 = 0; PorcentajeCantidadRubro3 = 0; PorcentajeCantidadRubro4 = 0; PorcentajeCantidadRubro5   = 0; RecaudacionTotal = 0;
        }
        public void InicializarVariables()
        {
            cantidad1 = 0; cantidad2 = 0; cantidad3 = 0; cantidad4 = 0; cantidad5 = 0; contadorDeTransacciones = 0; NumeroTransaccionMayor = 0; MontoTransaccionMayor = 0; PorcentajeCantidadRubro1 = 0; PorcentajeCantidadRubro2 = 0; PorcentajeCantidadRubro3 = 0; PorcentajeCantidadRubro4 = 0; PorcentajeCantidadRubro5 = 0; RecaudacionTotal = 0;
        }
        public void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            switch (rubro)
            {
                case 1: cantidad1 += cantidad; RecaudacionTotal += monto; break;
                case 2: cantidad2 += cantidad; RecaudacionTotal += monto; break;
                case 3: cantidad3 += cantidad; RecaudacionTotal += monto; break;
                case 4: cantidad4 += cantidad; RecaudacionTotal += monto; break;
                case 5: cantidad5 += cantidad; RecaudacionTotal += monto; break;
                default: Console.WriteLine("Rubro inexistente"); break;
            }
            if (NumeroTransaccionMayor == 0 && MontoTransaccionMayor == 0)
            {
                NumeroTransaccionMayor = nroTransaccion;
                MontoTransaccionMayor = monto;
            }
            else
            {
                if (monto > MontoTransaccionMayor)
                {
                    MontoTransaccionMayor = monto;
                    NumeroTransaccionMayor = nroTransaccion;
                }
            }
        }
        public void CalcularPorcentajesCantidadVentasPorRubro(int ContadorTransaccionesProgram)
        {
            PorcentajeCantidadRubro1 = 1.0 * (cantidad1 / (double)ContadorTransaccionesProgram) * 100;
            PorcentajeCantidadRubro2 = 1.0 * (cantidad2 / (double)ContadorTransaccionesProgram) * 100;
            PorcentajeCantidadRubro3 = 1.0 * (cantidad3 / (double)ContadorTransaccionesProgram) * 100;
            PorcentajeCantidadRubro4 = 1.0 * (cantidad4 / (double)ContadorTransaccionesProgram) * 100;
            PorcentajeCantidadRubro5 = 1.0 * (cantidad5 / (double)ContadorTransaccionesProgram) * 100;
        }
    }
}
