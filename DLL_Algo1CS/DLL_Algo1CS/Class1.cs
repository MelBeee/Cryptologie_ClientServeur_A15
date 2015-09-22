using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--- Algorithme d'AtBash ---\\

namespace DLL_Algo1CS
{
    public class Algo3
    {
        public static string Chiffrer(string Texte)
        {
            PrepareAtbash();
            return Transform(Texte);
        }

        public static string Dechiffrer(string Texte)
        {
            PrepareAtbash();
            return Transform(Texte);
        }


        static char[] _shift = new char[char.MaxValue];

        public static void PrepareAtbash()
        {
            // Set these as the same.
            for (int i = 0; i < char.MaxValue; i++)
            {
                _shift[i] = (char)i;
            }
            // Reverse order of capital letters.
            for (char c = 'A'; c <= 'Z'; c++)
            {
                _shift[(int)c] = (char)('Z' + 'A' - c);
            }
            // Reverse order of lowercase letters.
            for (char c = 'a'; c <= 'z'; c++)
            {
                _shift[(int)c] = (char)('z' + 'a' - c);
            }
        }

        public static string Transform(string value)
        {
            // Convert to char array
            char[] a = value.ToCharArray();
            // Shift each letter.
            for (int i = 0; i < a.Length; i++)
            {
                int t = (int)a[i];
                a[i] = _shift[t];
            }
            // Return new string.
            return new string(a);
        }
    }
}
