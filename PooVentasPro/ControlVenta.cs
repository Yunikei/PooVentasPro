using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVentasPro
{
    abstract class ControlVenta //Clase abstracta
    {  //Encapsulamiento
        public double Precio { get; set; }
        //Da y recibe un valor
        public double Cantidad { get; set; }
        //Da y recibe un valor


       //Método CalcularTotal
        public abstract double CalcularTotal(); //Clase abstracta
    }
}
