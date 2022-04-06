using System;
using Figgle;

namespace Hotel_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] Zimmernummer = { 45, 23, 3, 32 };
            string[] Vorname = { "John", "Paul", "George", "Ringo" };
            string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] Übernachtungen = { 1, 4, 12, 3 };
            double[] Rechnungsbetrag = { 82.46, 329.84, 989.52, 247 };

            string HauptAusw;
            bool p_wiederholen = false;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                Console.WriteLine
                    (FiggleFonts.Slant.Render("Hotel Check-In"));

                Console.Title = "Hotel Check-In";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Datensatz abrufen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit  ->  Beendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier können Sie die Daten des Kundes auslesen.");

                //Eingabeaufforderung 
                Console.WriteLine("Geben Sie nun die Zimmernummer oder den Namen ein.\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                short HauptAusw_short;

                bool flag = short.TryParse(HauptAusw, out HauptAusw_short);

                if (flag == true)
                {
                    // Methode von Short einfügen
                }
                else
                {
                    switch (HauptAusw)
                    {


                        case "exit":
                            Environment.Exit(0);
                            break;

                        default:

                            Console.WriteLine("Ungültige Eingabe");
                            Console.ReadKey();

                            (int, int) cPosAM = Console.GetCursorPosition();


                            ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                            break;
                    }
                }
            } while (p_wiederholen == true);
        }



        static (bool, short,string,string,short,double) GetData(short diff,short[] zn, string[] vn, string[]nn, short [] ue,double[] rb)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < zn.Length; i++)
            {
                if (diff == zn[i])
                {
                    index = i;
                    flag = true;
                }
            }


            return (flag,zn[index],vn[index],nn[index],ue[index],rb[index]);
        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < nn.Length; i++)
            {
                if (diff == nn[i])
                {
                    index = i;
                    flag = true;
                }
                    
            }

            return (flag,zn[index],vn[index], nn[index], ue[index], rb[index]);
        }

        public static void ClearCurrentConsoleLine(int from, int to)
        {

            for (int i = to; i >= from; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, from);


        }
    }
}
