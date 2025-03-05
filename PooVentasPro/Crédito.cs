using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVentasPro
{
    class Credito: ControlVenta //Herencia de ControlVenta
    {
        private const double IncrementoCredito = 1.05;

        public override double CalcularTotal()//Polimorfismo, calcular el total cuando se escoge la opción de crédito.
        {
            return (Precio * Cantidad) * IncrementoCredito;
            //5*5=25*.05=1.25+25=26.25
            // 25*1.05=26.25
        }
    }
}
