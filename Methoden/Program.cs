﻿using System;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int zeichenanzahl = 0;
            int durchgang = 0;

            Console.WriteLine("Geben Sie einen beliebigen Text ein.");

            string text = Console.ReadLine();
            Console.WriteLine("Geben Sie nun an, wie oft Ihr Durchgang durchlaufen werden soll");
            durchgang = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            zeichenanzahl = ausgabeTextMalX(text, durchgang);
            Console.Write("\nAnzahl der Buchstaben: {0}", zeichenanzahl);
        }

        static int ausgabeTextMalX(string i, int x)
        {
            for (int dg = 0; dg < x; dg++)
            {
                Console.WriteLine(i);
            }
            int zeichenanzahl = i.Length * x;
            return zeichenanzahl;
        } // CODE GESCHRIEBEN VON HÖGELE UND AHMAD
    }
}
