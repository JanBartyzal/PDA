using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopiruj
{
    internal class MojeSouboroveOperace
    {
        public void vytvorNahodnySoubor(string filename, int delka)
        {
            
            Random nahodneCislo = new Random();
            nahodneCislo = new Random((int)DateTime.Now.Ticks);
            
            byte[] nahodnaData = new byte[delka];
            nahodneCislo.NextBytes(nahodnaData);
            System.IO.File.WriteAllBytes(filename, nahodnaData);
        }
        public void kopirujSoubor(string zdroj, string cil)
        {
            System.IO.File.Copy(zdroj, cil, true);
        }
        public void ZkopirujANahrad(string zdroj, string cil, Dictionary<string,string> zamena)
        {
            string text = System.IO.File.ReadAllText(zdroj);
            foreach (var item in zamena)
            {
                text = text.Replace(item.Key, item.Value);
            }
            System.IO.File.WriteAllText(cil, text);
            
        }
    }
}
