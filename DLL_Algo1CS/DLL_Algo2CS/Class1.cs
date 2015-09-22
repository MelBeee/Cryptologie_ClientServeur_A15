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
            // Prend une partie de la chaine de texte et la deplace de X vers la droite (ou X = Cle) pour decrypter
            return Texte.Substring(Cle % Texte.Length) + Texte.Substring(0, Cle % Texte.Length);
        }

        public static string Dechiffrer(string Texte, int Cle)
        {
            // Prend une partie de la chaine de texte et la deplace de X vers la gauche (ou X = Cle) pour decrypter
            return Texte.Substring(Texte.Length - (Cle % Texte.Length)) + Texte.Substring(0, Texte.Length - (Cle % Texte.Length));
        }
    }
}
