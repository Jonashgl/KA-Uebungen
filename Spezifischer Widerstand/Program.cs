using System;

namespace Spezifischer_Widerstand
{
    class Program
    {
        static void Main(string[] args)
        {
            int Schrittgroese = Convert.ToInt32(Console.ReadLine());
            int abstand = Convert.ToInt32(Console.ReadLine());

            const double p = 0.017;
            const double A = 0.068;

            string y = "Meter"; string x = "Widerstand";


            Console.WriteLine("{0,7}{1,13}",y,x);

        }
    }
}
