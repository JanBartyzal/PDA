using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barvy
{
    internal class Barva
    {
        public string Nazev { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public int intenzita { get; } // Intenzita barvy (0-255)

        public Barva(string nazev, int r, int g, int b)
        {
            Nazev = nazev;
            R = r;
            G = g;
            B = b;
            intenzita = (r + g + b) / 3; 
        }

       

        public override string ToString()
        {
            //barva reprezentována v tomto formátu: 'název barvy (#FFFFFF):intenzita'. 
            string barvaHex = $"#{R:X2}{G:X2}{B:X2}";
            return $"{Nazev} ({barvaHex}):{intenzita}";

        }

        //nastavit komparacni funkci na intezitu a porovnat barvy
        public static int Porovnat(Barva b1, Barva b2)
        {
            if (b1.intenzita > b2.intenzita) return 1;
            else if (b1.intenzita < b2.intenzita) return -1;
            else return 0;
        }
    }
}
