using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moje.VstupAVystupDat
{

    /*
* a) Vytvořte statickou třídu NacteniHodnot s veřejnými metodami zajišťující načtení dat jednotlivých datových typů. 
* Třída bude umístěna v logické vrstvě a bude definována v pracovním prostoru Moje.VstupAVystupDat (tj. v prostoru Moje a 
* podprostoru VstupAVystupDat). Chybový stav (format exception, overflow exception) bude předáván generovanou výjimkou (exception).
* Implementujte metody pro známé datové typy - char, short, int, long, float a double, a string. 
* Metody pojmenujte adekvátně ReadChar, ReadShort, ReadUShort, ReadInt, ReadUInt, ReadFlow, ReadDouble, a ReadString .....

Načtená hodnota údaje bude předána návratovou hodnotou metody. Vyřešte situaci, že metoda bude načítat 
   hodnotu bez zobrazeného pokynu nebo pro načítanou hodnotu zobrazí pokyn předaný do metody parametrem. 
Uvedené metody budou přetížené*, defaultně bude metoda načítat hodnotu údaje adekvátního typu, nebo 
   zobrazí pokyn k načtení hodnotu a zajistí načtení hodnoty. 

Pozn: Vyzkoušejte funkčnost včetně ošetření chybového stavu alespoň na jedné metodě načítající 
   celočíselnou hodnotu. Dodržujte aspekty vrstvy aplikace.
*/

        public class NacteniHodnot
    {
            public static char ReadChar()
            {
                Console.Write("Zadejte znak: ");
                try
            {
                    return char.Parse(Console.ReadLine());
                }
                catch (FormatException)
            {
                    Console.WriteLine("Zadali jste neplatný znak.");
                    return ReadChar();
                }
                catch (Exception)
            {
                    Console.WriteLine("Nastala neidentifikovatelná chyba.");
                    return ReadChar();
                }

            }

            public static short ReadShort()
            {
                Console.Write("Zadejte krátké číslo: ");
            try
            { 
                return short.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadali jste neplatné číslo.");
                return ReadShort();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zadali jste příliš velké číslo.");
                return ReadShort();
            }
            catch (Exception)
            {
                Console.WriteLine("Nastala neidentifikovatelná chyba.");
                return ReadShort();
            }


            }

            public static ushort ReadUShort()
            {
                Console.Write("Zadejte krátké nezáporné číslo: ");
            try
            {
                return ushort.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadali jste neplatné číslo.");
                return ReadUShort();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zadali jste příliš velké číslo.");
                return ReadUShort();
            }
            catch (Exception)
            {
                Console.WriteLine("Nastala neidentifikovatelná chyba.");
                return ReadUShort();
            }
                
            }

            public static int ReadInt()
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

            public static uint ReadUInt()
            {
                Console.Write("Zadejte nezáporné celé číslo: ");
            try
            {
                return uint.Parse(Console.ReadLine());
                            }
            catch (FormatException)
            {
                Console.WriteLine("Zadali jste neplatné číslo.");
                return ReadUInt();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zadali jste příliš velké číslo.");
                return ReadUInt();
            }
            catch (Exception)
            {
                Console.WriteLine("Nastala neidentifikovatelná chyba.");
                return ReadUInt();
            }
            }

            public static float ReadFloat()
            {
                Console.Write("Zadejte desetinné číslo: ");
            try
            {
                return float.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadali jste neplatné číslo.");
                return ReadFloat();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zadali jste příliš velké číslo.");
                return ReadFloat();
            }
            catch (Exception)
            {
                Console.WriteLine("Nastala neidentifikovatelná chyba.");
                return ReadFloat();
            }
            }

            public static double ReadDouble()
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

        public static string ReadString()
            {
                Console.Write("Zadejte text: ");
                try
            {
                    return Console.ReadLine();
                }
                catch (Exception)
            {
                    Console.WriteLine("Nastala neidentifikovatelná chyba.");
                    return ReadString();
                }
            }
        }   
    
}
