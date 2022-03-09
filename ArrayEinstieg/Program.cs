using System;

namespace ArrayEinstieg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] Noten = new int[n];
            int Noten2 = 0;
            double Notensumme = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Geben Sie die {0} Note ein.", i+1);

                Noten2 = Convert.ToInt32(Console.ReadLine());
                Noten[i] = Noten2;
                Notensumme = Notensumme + Noten2;
            }
            
            Console.WriteLine($"Der Notendurschnitt beträgt {Notensumme / 20}\n");
            Console.WriteLine("Die Noten werden nun untereinander ausgegeben");
            foreach(int i in Noten) 
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        // Erarbeitet von Ahmad und Högele
    }
}
