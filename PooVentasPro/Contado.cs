using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVentasPro
{
    class Contado : ControlVenta //Herencia de ControlVenta
    {
        public override double CalcularTotal()//Polimorfismo para dar el total al momento de seleccionar Contado.
        {
            return (Precio * Cantidad);
            
        }
    }
}
