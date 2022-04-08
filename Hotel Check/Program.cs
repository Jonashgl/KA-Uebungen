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
            bool wiederholen = false;
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
                Console.Clear();
                short HauptAusw_short;
                bool flag = short.TryParse(HauptAusw, out HauptAusw_short);

                if (flag == true)
                {
                    var Daten = GetData(HauptAusw_short, Zimmernummer, Vorname, Nachname, Übernachtungen, Rechnungsbetrag);
                    if(Daten.Item1 == true)
                    {
                        short zimmernummer_gast = Daten.Item2;
                        string vorname_gast = Daten.Item3;
                        string nachname_gast = Daten.Item4;
                        short übernachtungen_gast = Daten.Item5;
                        double rechnungsbetrag_gast = Daten.Item6;
                        Console.WriteLine("Zimmernummer\tVorname\t\tNachname\tÜbernachtungen\tRechnungsbetrag");
                        Console.WriteLine($"{zimmernummer_gast}\t\t{vorname_gast}\t\t{nachname_gast}\t\t{übernachtungen_gast}\t\t{rechnungsbetrag_gast}");
                    }
                    else
                    {
                        Console.WriteLine("Kein Item gefunden!");
                    }
                }
                else
                {
                    var daten = GetData(HauptAusw, Zimmernummer, Vorname, Nachname, Übernachtungen, Rechnungsbetrag);
                    if (daten.Item1 == true) 
                    {
                        short zimmernummer_gast = daten.Item2;
                        string vorname_gast = daten.Item3;
                        string nachname_gast = daten.Item4;
                        short übernachtungen_gast = daten.Item5;
                        double rechnungsbetrag_gast = daten.Item6;
                        Console.WriteLine("Zimmernummer\tVorname\t\tNachname\tÜbernachtungen\tRechnungsbetrag");
                        Console.WriteLine($"{zimmernummer_gast}\t\t{vorname_gast}\t\t{nachname_gast}\t\t{übernachtungen_gast}\t\t{rechnungsbetrag_gast}");
                    }
                }

                Console.WriteLine("\nZum fortfahren eine beliebige Taste drücken.");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Möchten Sie das Programm wiederholen? Bei falscher Eingabe wird das Programm geschlossen.\n");
                Console.WriteLine("Ja     - Programm wiederholen");
                Console.WriteLine("Nein   - Programm schließen\n");
                Console.WriteLine("Eingabe:");
                string str_wiederholen;
                str_wiederholen = Console.ReadLine();
                switch (str_wiederholen)
                {
                    case "Ja":
                        Console.Clear();
                        wiederholen = true;
                        break;

                    case "Nein":
                        Environment.Exit(0);
                        break;

                    default:

                        Environment.Exit(0);
                        break;
                }
            } while (wiederholen == true);
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
    }
}
