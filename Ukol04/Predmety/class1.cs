using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Predmety
{
    internal class Predmet
    {
        string nazev;
        string zkratka;
        public string Nazev
        {
            get { return nazev; }
            set { nazev = value; }
        }
        public string Zkratka
        {
            get { return zkratka; }
            set { zkratka = value; }
        }
        public Predmet(string nazev, string zkratka)
        {
            this.nazev = nazev;
            this.zkratka = zkratka;
        }
    }

    internal class Vyuka
    {
     
        public List<Predmet> predmety = new List<Predmet>();
        public List<Predmet> zvolene = new List<Predmet>();

        public bool PridatPredmet(Predmet predmet)
        {
            bool find = false;
            foreach (Predmet p in predmety)
            {
                if (p.Zkratka == predmet.Zkratka)
                {
                    find= true; // Předmět již existuje
                }
            }
            if (find)
            {
                return false; // Předmět již existuje
            }
            
            predmety.Add(predmet);
            return true;
        }
        public void OdebratPredmet(Predmet predmet)
        {
            predmety.Remove(predmet);
        }

        public void ZvolitPredmet(Predmet predmet)
        {
            if (predmety.Contains(predmet))
            {
                zvolene.Add(predmet);
            }
        
        }
        public void OdebratZvolenyPredmet(Predmet predmet)
        {
            zvolene.Remove(predmet);
        }
        public bool ExportPredmety2CSV(string nazevSouboru)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nazevSouboru))
                {
                    foreach (Predmet predmet in predmety)
                    {
                        writer.WriteLine(predmet.ToString());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při exportu do CSV: " + ex.Message);
                return false;
            }
        }
        public bool ImportPredmetyZCSV(string nazevSouboru)
        {
            try
            {
                using (StreamReader reader = new StreamReader(nazevSouboru))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            Predmet predmet = new Predmet(parts[0], parts[1]);
                            PridatPredmet(predmet);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při importu z CSV: " + ex.Message);
                return false;
            }
        }
        public bool ExportZvolenePredmety2CSV(string nazevSouboru)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nazevSouboru))
                {
                    foreach (Predmet predmet in zvolene)
                    {
                        writer.WriteLine(predmet.ToString());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při exportu zvolených předmětů do CSV: " + ex.Message);
                return false;
            }
        }






    }

}

