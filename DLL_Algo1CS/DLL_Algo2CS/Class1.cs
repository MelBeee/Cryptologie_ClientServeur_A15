using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--- Algorithme Circulaire ---\\

namespace DLL_Algo2CS
{
    public class Algo2
    {
        public static string Chiffrer(string Texte, int Cle)
        {
            String Encoder = "";
            Encoder = Texte.Substring(Cle % Texte.Length) + Texte.Substring(0, Cle % Texte.Length);
            return Encoder;
        }

        public static string Dechiffrer(string Texte, int Cle)
        {
            String Encoder = "";
            Encoder = Texte.Substring(Texte.Length - (Cle % Texte.Length)) + Texte.Substring(0, Texte.Length - (Cle % Texte.Length));
            return Encoder;
        }
    }
}
