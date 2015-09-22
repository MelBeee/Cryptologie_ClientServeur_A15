using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--- Algorithme de Rotation ---\\

namespace DLL_Algo3CS
{
    public class Algo1
    {
        const int FIRST_MAJUSCULE = 65;
        const int LAST_MAJUSCULE = 90;
        const int FIRST_MINUSCULE = 97;
        const int LAST_MINUSCULE = 122;
        const int C_MAJ_VERS_MIN = 6;
        const int C_MIN_VERS_MAJ = 64;
        const int D_MAJ_VERS_MIN = 58;
        const int D_MIN_VERS_MAJ = 6;


        public static string Chiffrer(string Texte, int Cle)
        {
            string chaine = "";
            // Pour chaque caractere dans la chaine de caractere (Texte) 
            for (int i = 0; i < Texte.Length; i++)
            {
                // Si le caractere est entre 65 et 90 (Etant les lettres de A à Z en majuscule) 
                if (Texte[i] >= FIRST_MAJUSCULE && Texte[i] <= LAST_MAJUSCULE)
                {
                    // On ajoute la valeur X (Cle) au caractere 
                    // si l'additon depasse 90, on ne veut pas que ca le transforme en autre chose que des lettres donc on additionne 6 pour se rendre dans les minuscule (97)
                    if (Texte[i] + Cle > LAST_MAJUSCULE)
                        chaine += Convert.ToChar(Texte[i] + Cle + C_MAJ_VERS_MIN);
                    else // sinon on fait juste ajouter la clé au caractere pour le transformer
                        chaine += Convert.ToChar(Texte[i] + Cle);
                }
                // Si le caractere est entre 97 et 122 (Etant les lettres de A à Z en minuscule) 
                else if (Texte[i] >= FIRST_MINUSCULE && Texte[i] <= LAST_MINUSCULE)
                {
                    // On ajoute la valeur X (Cle) au caractere 
                    // si l'additon depasse 122, on ne veut pas que ca le transforme en autre chose que des lettres donc on cherche le 1er caractere des majuscule et on addition 64 pour se rendre dans les majuscule (65)
                    if (Texte[i] + Cle > LAST_MINUSCULE)
                        chaine += Convert.ToChar(((Texte[i] + Cle) % LAST_MINUSCULE) + C_MIN_VERS_MAJ);
                    else // sinon on fait juste ajouter la clé au caractere pour le transformer
                        chaine += Convert.ToChar(Texte[i] + Cle);
                }
                else//si le caractère n'est pas dans l'alphabet on ne le transforme pas, on ne le crypte pas non plus 
                {
                    chaine += Texte[i];
                }
            } // retourne la chaine crypter 
            return chaine;
        }

        public static string Dechiffrer(string Texte, int Cle)
        {
            string chaine = "";
            // Pour chaque caractere dans la chaine de caractere (Texte) 
            for (int i = 0; i < Texte.Length; i++)
            {
                // Si le caractere est entre 65 et 90 (Etant les lettres de A à Z en majuscule) 
                if (Texte[i] >= FIRST_MAJUSCULE && Texte[i] <= LAST_MAJUSCULE)
                {
                    // On enleve la valeur X (Cle) au caractere 
                    // si la soustraction est plus petit que la premiere majuscule, on ne veut pas que ca le transforme en autre chose que des lettres donc on additionne 58 pour se rendre dans les minuscule (97)
                    if (Texte[i] - Cle < FIRST_MAJUSCULE)
                        chaine += Convert.ToChar(Texte[i] - Cle + D_MAJ_VERS_MIN);
                    else // sinon on fait juste ajouter la clé au caractere pour le transformer
                        chaine += Convert.ToChar(Texte[i] - Cle);
                }
                // Si le caractere est entre 97 et 122 (Etant les lettres de A à Z en minuscule) 
                else if (Texte[i] >= FIRST_MINUSCULE && Texte[i] <= LAST_MINUSCULE)
                {
                    // On enleve la valeur X (Cle) au caractere 
                    // si la soustraction est plus petit que la premiere minuscule, on ne veut pas que ca le transforme en autre chose que des lettres donc on cherche le 1er caractere des majuscule et on addition 6 pour se rendre dans les majuscule (65)
                    if (Texte[i] - Cle < FIRST_MINUSCULE)
                        chaine += Convert.ToChar(Texte[i] - Cle - D_MIN_VERS_MAJ);
                    else // sinon on fait juste ajouter la clé au caractere pour le transformer
                        chaine += Convert.ToChar(Texte[i] - Cle);
                }
                else//si le caractère n'est pas dans l'alphabet on ne le transforme pas, on ne le crypte pas non plus 
                {
                    chaine += Texte[i];
                }
            } // retourne la chaine decrypter
            return chaine;
        }
    }
}
        
