using System;

namespace Alter
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Bitte Alter eingeben");
                double Alter = Convert.ToDouble(Console.ReadLine());
                while (Alter <= 0 || Alter > 120)
                {
                    Console.WriteLine("Fehlermeldung"); Console.WriteLine("Bitte Alter erneuert eingeben"); double Alter1 = Convert.ToDouble(Console.ReadLine());
                }

                if (Alter < 18)
            {
                Console.WriteLine("Downloadverweigerung");
            }

                else
            {
                Console.WriteLine("Downloadbestätigung");
            }


                //if (Alter < 18) Console.WriteLine("Downloadverweigung");
                //{
                //Console.WriteLine("Downloadverweigung");
                //}

                //else
                //{
                //    Console.WriteLine("Downloadbestätigung");
                //}
        }
    }
}
