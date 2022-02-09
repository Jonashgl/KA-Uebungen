using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinsKAÜbung
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Jahr"; string b = "Guthaben"; string c = "Zinsen"; string d = "K-Zinsen"; string e = "Bilanz";

            Console.WriteLine("Geben Sie Ihr Kapital an.");
            double Kapital = Convert.ToDouble(Console.ReadLine()); Console.Clear();
            Console.WriteLine("Nun geben Sie bitte Ihre Anlagedauer an.");
            int Anlagedauer = Convert.ToInt32(Console.ReadLine()); Console.Clear();
            Console.WriteLine("Geben Sie nun Ihren Zinssatz ein.");
            double Zinssatz = Convert.ToDouble(Console.ReadLine()); Console.Clear();

            double KZinsen = 0;
            double Bilanz = 0;

            Console.WriteLine("{0,4} {1,10} {2,8} {3,10} {4,8}", a, b, c, d, e);

            double neu_Kapital = Kapital;
            double Zinsen = 0;


            for (int i = 1; i <= 43; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
    
            for (int i = 1; i <= Anlagedauer; i++)
            {
                Zinsen = neu_Kapital * (Zinssatz / 100);
                KZinsen = KZinsen + Zinsen;
                Bilanz = neu_Kapital + Zinsen;
                Console.WriteLine("{0,4} {1,10:F2} {2,8:F2} {3,10:F2} {4,8:F2}", i, neu_Kapital, Zinsen, KZinsen, Bilanz);
                neu_Kapital = neu_Kapital + Zinsen;

            }
            Console.ReadKey();
        }
    }
}
