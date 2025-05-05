using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadrz
{
    /*
     * i) Definice třídy:
Definujte třídu Nádrž. Tato třída (objekt) má atribut stav nádrže (aktuální stav nádrže) a objem (kapacitu). Má metody pro přidávání do nádrže a pro odebírání z nádrže. 
Bude umožněno pro objekt nádrže přidávat a odebírat, dále bude umožněno číst aktuální stav nádrže a kapacitu nádrže. Nebude možné přímo měnit hodnotu těchto atributů. 
Kapacitu nádrže chceme řešit jako "konstantu", ale její hodnota se bude nastavovat v okamžiku vytvoření objektu nádrže na základě hodnoty předané parametrem metody konstruktoru. Jak buda tento atribut (= konstanta) realizován?
     */
    class NadrzNelzeProvestOperaciException : Exception
    {
        public NadrzNelzeProvestOperaciException(string message) : base(message)
        {
        }
    }
    class NelzeVlozitDoNadrzeException : Exception
    {
        public NelzeVlozitDoNadrzeException(string message) : base(message)
        {
        }
    }

    class NelzeOdebratZNadrzeException : Exception
    {
        public NelzeOdebratZNadrzeException(string message) : base(message)
        {
        }
    }

    class Nadrz
    {
        private int _stavNadrze;
        private readonly int _objem;
        private string _nazevNadrze;
        private int _numID;

        public Nadrz(int objem)
        {
            _objem = objem;
            _stavNadrze = 0;
            _numID=0;
            _nazevNadrze="";
        }

        public void Pridat(int mnozstvi)
        {
            if (_stavNadrze + mnozstvi <= _objem)
            {
                _stavNadrze += mnozstvi;
            }
            else
            {
                throw new NelzeVlozitDoNadrzeException("Nádrž je plná, nelze přidat více vody.");
            }
        }

        public void Odebrat(int mnozstvi)
        {
            if (_stavNadrze - mnozstvi >= 0)
            {
                _stavNadrze -= mnozstvi;
            }
            else
            {
                throw new NelzeOdebratZNadrzeException("Nádrž je prázdná, nelze odebrat více vody.");
            }
        }

        public int StavNadrze
        {
            get { return _stavNadrze; }
        }

        public int Objem
        {
            get { return _objem; }
        }

        public override string ToString()
        {
            return $"{_stavNadrze}/{_objem} ({(_stavNadrze * 100) / _objem} %)";
        }
        public string NazevNadrze
        {
            get { return _nazevNadrze; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Název nádrže nemůže být prázdný.");
                }
                _nazevNadrze = value;
            }
        }
        public int NumID
        {
            get { return _numID; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ID nádrže nemůže být záporné.");
                }
                _numID = value;
            }
        }
    }
}
