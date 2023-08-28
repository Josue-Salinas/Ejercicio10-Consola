using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuánto costó en total los platillos?");
            double  montoDesc, impuesto, subTotal, ImportePago, costo;
            costo= double.Parse(Console.ReadLine());
            if (costo <= 100) 
            {
                montoDesc = costo * 0.1;
            }
            else 
            {
                montoDesc= costo * 0.2;
            }
            subTotal = costo - montoDesc;
            impuesto = subTotal * 0.18;
            ImportePago = subTotal + impuesto;
            Console.WriteLine("Descuento S/."+montoDesc);
            Console.WriteLine("Subtotal S/." + subTotal);
            Console.WriteLine("Impuesto S/."+impuesto);
            Console.WriteLine("Importe de pago es S/." + ImportePago);
            Console.ReadKey();
        }
    }
}
