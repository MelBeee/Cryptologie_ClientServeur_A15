using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Algorithme de Rotation

namespace DLL_Algo3CS
{
    public class Algo1
    {
        public static string Chiffrer(string Texte, int Cle)
        {
            string chaine = "";
            for (int i = 0; i < Texte.Length; i++)
            {
                //entre 65 et 90 	MAJUSCULE
                if (Texte[i] >= 65 && Texte[i] <= 90)
                {
                    if (Texte[i] + Cle > 90)
                        chaine += Convert.ToChar(Texte[i] + Cle + 6);
                    else
                        chaine += Convert.ToChar(Texte[i] + Cle);
                }
                //entre 97 et 122	minuscule
                else if (Texte[i] >= 97 && Texte[i] <= 122)
                {
                    if (Texte[i] + Cle > 122)
                        chaine += Convert.ToChar(((Texte[i] + Cle) % 122) + 64);
                    else
                        chaine += Convert.ToChar(Texte[i] + Cle);
                }
                else//si le caractère n'est pas dans l'alphabete
                {
                    chaine += Texte[i];
                }
            }
            return chaine;
        }

        public static string Dechiffrer(string Texte, int Cle)
        {
            string chaine = "";
            for (int i = 0; i < Texte.Length; i++)
            {
                //entre 65 et 90 	MAJUSCULE
                if (Texte[i] >= 65 && Texte[i] <= 90)
                {
                    if (Texte[i] - Cle < 65)
                        chaine += Convert.ToChar(Texte[i] - Cle + 58);
                    else
                        chaine += Convert.ToChar(Texte[i] - Cle);
                }
                //entre 97 et 122	minuscule
                else if (Texte[i] >= 97 && Texte[i] <= 122)
                {
                    if (Texte[i] - Cle < 97)
                        chaine += Convert.ToChar(Texte[i] - Cle - 6);
                    else
                        chaine += Convert.ToChar(Texte[i] - Cle);
                }
                else//si le caractère n'est pas dans l'alphabete
                {
                    chaine += Texte[i];
                }
            }
            return chaine;
        }
    }
}
        
