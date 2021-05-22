using System;

namespace Flujo_de_datos___C2_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {

            int precio;
            string pago;
            double cuenta;

            Console.WriteLine("Introduzca el precio");
            precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elija la forma de pago: efectivo o tarjeta");
            pago = Console.ReadLine();

            if(pago == "tarjeta")
            {
                Console.WriteLine("Introduzca el numero de cuenta");
                cuenta = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
