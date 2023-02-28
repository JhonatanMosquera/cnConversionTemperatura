using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnConversionTemperatura
{
    /// <summary>
    /// Nombre: Jhonatan Stiven Mosquera Moreno
    /// fecha: 24/02/2023
    /// descripcion: Conversion temperatura
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-CELSIUS");
            Console.WriteLine("2-FAHRENHET");
            int Dato = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de temperatura");
            double Temperatura = Convert.ToDouble(Console.ReadLine());

            switch (Dato)
            {
                case 1:
                    Console.WriteLine("La temperatura en fahrenht es: " + metodo2Farihent(Temperatura));
                    break;
                case 2:
                    Console.WriteLine("La temperatura en fahrenht en celsius es: " + metodo1Celsius(Temperatura));
                    break;

            }

            Console.ReadKey();

        }

        static double metodo1Celsius(double Temperatura)
        {
            double conversion;
            conversion = (Temperatura - 32) / 1.8;
            return conversion;
        }

        static double metodo2Farihent(double Temperatura)
        {
            double conversion;
            conversion = (Temperatura * 1.8) + 32;
            return conversion;
        }




    }

}

