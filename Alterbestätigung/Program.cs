using System;

namespace Alterbestätigung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Ihr alter ein.");
            int alter = Convert.ToInt32(Console.ReadLine());

            while (alter <= 0 || alter >120)
            {
                Console.WriteLine("Fehlermeldung, bitte geben Sie ihr alter erneut ein.");
                alter = Convert.ToInt32(Console.ReadLine());
            }

            if (alter < 18)
            {
                Console.WriteLine("Downloadverweigerung");
            }
            else
            {
                Console.WriteLine("Downloadbestätigung");
            }
        }
    }
}
