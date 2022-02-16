using System;

namespace Spezifischer_Widerstand
{
    class Program
    {
        static void Main(string[] args)
        {
            double Schrittgroese = Convert.ToInt32(Console.ReadLine());
            double abstand = Convert.ToInt32(Console.ReadLine());

            const double p = 0.017;
            const double A = 0.068;

            string y = "Meter"; string x = "Widerstand";


            Console.WriteLine("{0,7}{1,13}",y,x);

            for(double l = 0;l<=abstand;l=l+Schrittgroese)
            {
                double R = p * (l / A);
                Console.WriteLine($"{l,7}{R,13:F2}");
            }

        }
    }
}
