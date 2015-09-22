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
            // Il faut préparer l'algorithme qui sera utiliser pour crypter
            PrepareAtbash();
            // On retourne les données transformées
            return Transform(Texte);
        }

        public static string Dechiffrer(string Texte)
        {
            // Il faut préparer l'algorithme qui sera utiliser pour decrypter
            PrepareAtbash();
            // On retourne les données transformées
            return Transform(Texte);
        }


        // tableau qui contient tous les caractères 
        static char[] tabCaractere = new char[char.MaxValue];

        public static void PrepareAtbash()
        {
            // Rempli le tableau de tout les caractères
            for (int i = 0; i < char.MaxValue; i++)
            {
                tabCaractere[i] = (char)i;
            }
            // Change l'ordre de A a Z pour Z a A pour crypter par la suite
            for (char c = 'A'; c <= 'Z'; c++)
            {
                tabCaractere[(int)c] = (char)('Z' + 'A' - c);
            }
            // Change l'ordre de a à z pour z à a pour crypter par la suite 
            for (char c = 'a'; c <= 'z'; c++)
            {
                tabCaractere[(int)c] = (char)('z' + 'a' - c);
            }
        }

        // Ici on recoit la chaine de caractere et on la retourne crypté ou décrypter selon le cas
        public static string Transform(string Texte)
        {
            // on met notre string dans un tableau de char 
            char[] a = Texte.ToCharArray();
            // on change chaque lettre une a une
            for (int i = 0; i < a.Length; i++)
            {
                int t = (int)a[i];
                a[i] = tabCaractere[t];
            }
            // retourne le tableau de char transformé en string
            return new string(a);
        }
    }
}
