using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _01_VstupAVystupDat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadali jste číslo:" + ReadInt().ToString());
            Console.WriteLine("Zadali jste číslo:" + ReadDouble().ToString());

            //b();
            //c();
            //d();
            //e();
            //f();


            Console.WriteLine("Konec programu.");
            Console.ReadKey();


        }


        static int ReadInt()
        {
            Console.Write("Zadejte celé číslo: ");
            string input = Console.ReadLine();

            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadali jste neplatné číslo.");
                return ReadInt();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zadali jste příliš velké číslo.");
                return ReadInt();
            }
            catch (Exception)
            {
                Console.WriteLine("Nastala neidentifikovatelná chyba.");
                return ReadInt();
            }

           
        }

        static double ReadDouble()
        {
            Console.Write("Zadejte realné (double) číslo: ");
            string input = Console.ReadLine();

            try
            {
                return double.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadali jste neplatné číslo.");
                return ReadDouble();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zadali jste příliš velké číslo.");
                return ReadDouble();
            }
            catch (Exception)
            {
                Console.WriteLine("Nastala neidentifikovatelná chyba.");
                return ReadDouble();
            }


        }
        //
        //b) fragment programu zobrazí zápis znaků v escape sekvenci.Zobrazovaný text je "Pro označení escape-sekvence se používá znak \. Konec řádky \n, tabulátor \t, backspace \b, uvozovky ", apostrof ', zavináč @, a zápis znaku pomocí '\x041'".

        static void b()
        {
            Console.WriteLine("Pro označení escape-sekvence se používá znak \\.");
            Console.WriteLine("Konec řádky \\n, tabulátor \\t, backspace \\b, uvozovky \", apostrof ', zavináč @, a zápis znaku pomocí '\\x041'.");
        }

        /* U níže uvedených fragmentů nezapomeňte ošetřovat chybové stavy vstupu!!!

        c) fragment programu pro zadané celé/reálné číslo zobrazí jeho druhou a třetí mocninu.Výsledek bude mít tento formát: 2.5<tab>2.5^2=6.25<tab>2.5^3=15.625
            Druhá mocnina se zaokrouhlí na dvě desetinná místa a třetí mocnina se zaokrouhlí na tři desetinná místa.Ošetřete chybové stavy vzniklé při načítání hodnot ze standardního vstupu (klávesnice).


                    Ukázka: 
            Druhá a třetí mocnina čísla
                    Zadej reálné číslo s desetinnou částí: 2.5
            Výsledek: 2.5	2.5^2=6.25	2.5^3=15.625


        Pozn: Mezi hodnotami výsledky je tabulátor.
        */
        static void c()
        {
            double number = ReadDouble();
            double square = Math.Pow(number, 2);
            double cube = Math.Pow(number, 3);

            Console.WriteLine($"{number}\t{number}^2={square}\t{number}^3={cube}");

        }

        /*
        d) fragment programu pro zadanou kapacitu rozvrhové skupiny a zadaný počet zapsaných studentů zobrazí procentuální naplnění skupiny. Např. 25/30 (83,3 %)

            Ukázka:
            Zadej kapacitu rozvrhové skupiny:
            Zadej počet studentů:
            Výsledek: 25/30 (83,3 %)
	
            Pozn: V případě zadání neplatné hodnoty počtu studentů (větší než kapacita, záporné číslo) se opakuje zadání hodnotu studentů. 	 

         * */

        static void d()
        {
            int capacity = ReadInt();
            int students = ReadInt();

            if (students > capacity || students < 0)
            {
                Console.WriteLine("Neplatný počet studentů.");
                d();
            }
            else
            {
                double percentage = (double)students / capacity * 100;
                Console.WriteLine($"{students}/{capacity} ({percentage} %)");
            }
        }

        /*
         e) fragment programu pro sestavený datum udávající den a čas zkoušky zobrazí informaci o zkoušce ve tvaru název předmětu a datum konání zkoušky ve standardním formátu a ve formátu pro sql. 

            Ukázka:
            Název předmětu zkoušku:
	            Programování desktopových aplikací
            Datum a čas zkoušky:
	            21. únor 2025 11:37:00

            Informace o zkoušce:
	            21.02.2025 11:37:00	Programování desktopových aplikací


            Program upravte a rozšiřte tak, aby neumožnil zadat datum starší než aktuální datum, resp. datum novější alespoň + 1 den. 

            Pozn: Nastudujte si parsering údaje data a času z textu. Vyzkoušejte v realizaci. 
          
         */

        static void e()
        {
            Console.WriteLine("Název předmětu zkoušku:");
            string subject = Console.ReadLine();

            DateTime date;
            while (true)
            {
                Console.WriteLine("Datum a čas zkoušky:");
                string input = Console.ReadLine();

                if (DateTime.TryParse(input, out date))
                {
                    if (date < DateTime.Now)
                    {
                        Console.WriteLine("Zadali jste minulé datum.");
                    }
                    else if (date < DateTime.Now.AddDays(1))
                    {
                        Console.WriteLine("Informace o zkoušce: "+date.ToString("dd.MM.yyyy HH:mm:ss") + " " + subject);
                    }
                }
            }
        }

        /*
         * f) fragment programu, který zobrazí ASCII kód stisknuté klávesy. Opakuje, dokud nebude zadána (stisknuta) klávesa Escape (Esc).
         * */

        static void f()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.WriteLine((int)key.KeyChar);
            } while (key.Key != ConsoleKey.Escape);
        }


    }
}
