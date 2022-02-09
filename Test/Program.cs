using System;

namespace SchleifenA9
{
    class Program
    {
        static void Main(string[] args)
        {


            double K = 0, K_neu = 0, p = 0;
            int jahre = 0;

            Console.WriteLine("Geben Sie ihr Kapital an");
            K = Convert.ToDouble(Console.ReadLine());
            K_neu = K;

            Console.WriteLine("Geben Sie ihren Zinssatz an");
            p = Convert.ToDouble(Console.ReadLine());

            while (K_neu < K * 2)
            {
                K_neu = K_neu + K_neu * (p / 100);
                jahre++;
            }

            Console.WriteLine("Es dauert etwa {0} Jahre um das Kapital zu verdoppeln", jahre);
        }
    }
}