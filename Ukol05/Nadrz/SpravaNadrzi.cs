using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadrz
{
    internal class SpravaNadrzi
    {
        List<Nadrz> nadrze = new List<Nadrz>();
        
        public Nadrz NajdiNadrz(string Nazev)
        {
            Nadrz nadrzToFind = nadrze.FirstOrDefault(n => n.NazevNadrze.ToLower() == Nazev.ToLower());
            if (nadrzToFind != null)
            {
                return nadrzToFind;
            }
            return null;
        }
        public Nadrz NajdiNadrz(int id)
        {
            Nadrz nadrzToFind = nadrze.FirstOrDefault(n => n.NumID == id);
            if (nadrzToFind != null)
            {
                return nadrzToFind;
            }
            return null;
        }

        public void Clear()
        {
            nadrze.Clear();
        }

        public int maxIDNadrze()
        {
            int id= 0;

            foreach (Nadrz n in nadrze)
            {
                if (n.NumID > id)
                {
                    id= n.NumID;
                }
            }
            return id;
        }


        public void PridatNadrz(string Nazev, int objem)
        {
            Nadrz novaNadrz = new Nadrz(objem);
            novaNadrz.NazevNadrze = Nazev;
            Nadrz nadrzToAdd = NajdiNadrz(Nazev);
            if (nadrzToAdd != null)
            {
                throw new NadrzNelzeProvestOperaciException("Nádrž s tímto názvem již existuje.");
            }

            novaNadrz.NumID=maxIDNadrze()+1;
            nadrze.Add(novaNadrz);

        }

        public void PridatNadrz(string Nazev, int objem, int stav)
        {
            Nadrz novaNadrz = new Nadrz(objem);
            novaNadrz.NazevNadrze = Nazev;
            Nadrz nadrzToAdd = NajdiNadrz(Nazev);
            novaNadrz.Pridat(stav);
            if (nadrzToAdd != null)
            {
                throw new NadrzNelzeProvestOperaciException("Nádrž s tímto názvem již existuje.");
            }

            novaNadrz.NumID = maxIDNadrze() + 1;
            nadrze.Add(novaNadrz);

        }
        public void OdebratNadrz(string Nazev)
        {
            Nadrz nadrzToRemove = NajdiNadrz(Nazev);
            if (nadrzToRemove != null)
            {
                if (nadrzToRemove.StavNadrze > 0)
                {
                    throw new NadrzNelzeProvestOperaciException("Nádrž není prázdná, nelze ji odebrat.");
                }
                nadrze.Remove(nadrzToRemove);
            }
            else
            {
                throw new NadrzNelzeProvestOperaciException("Nádrž s tímto názvem neexistuje.");
            }
        }

        public List<Nadrz> ZobrazNadrze()
        {
            return nadrze;
        }
        public void PridatDoNadrze(string Nazev, int mnozstvi)
        {
            Nadrz nadrzToAdd = nadrze.FirstOrDefault(n => n.NazevNadrze == Nazev);
            if (nadrzToAdd != null)
            {
                nadrzToAdd.Pridat(mnozstvi);
            }
            else
            {
                throw new NadrzNelzeProvestOperaciException("Nádrž s tímto názvem neexistuje.");
            }
        }
        public void OdebratZNadrze(string Nazev, int mnozstvi)
        {
            Nadrz nadrzToRemove = nadrze.FirstOrDefault(n => n.NazevNadrze == Nazev);
            if (nadrzToRemove != null)
            {
                nadrzToRemove.Odebrat(mnozstvi);
            }
            else
            {
                throw new NadrzNelzeProvestOperaciException("Nádrž s tímto názvem neexistuje.");
            }
        }

        public void SeradVzestupNadrze()
        {
            nadrze = nadrze.OrderBy(n => n.NazevNadrze).ToList();
        }   
        public void SeradSestupNadrze()
        {
            nadrze = nadrze.OrderByDescending(n => n.NazevNadrze).ToList();
        }
        public void SeradVzestupObjem()
        {
            nadrze = nadrze.OrderBy(n => n.Objem).ToList();
        }
        public void SeradSestupObjem()
        {
            nadrze = nadrze.OrderByDescending(n => n.Objem).ToList();
        }
        public void SeradVzestupStav()
        {
            nadrze = nadrze.OrderBy(n => n.StavNadrze).ToList();
        }
        public void SeradSestupStav()
        {
            nadrze = nadrze.OrderByDescending(n => n.StavNadrze).ToList();
        }
        public void SeradVzestupID()
        {
            nadrze = nadrze.OrderBy(n => n.NumID).ToList();
        }
        public void SeradSestupID()
        {
            nadrze = nadrze.OrderByDescending(n => n.NumID).ToList();
        }

    }
}
