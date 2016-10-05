using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        #region fonctions maths
        static float SaisirNombre(string prompt)
        {
            string reponse;

            Console.WriteLine(prompt);
            reponse = Console.ReadLine();
            return float.Parse(reponse); // Convertir une String en Float
        }

        // A structurer //////////////////////////////////
        static void Additionner(float a, float b)
        {
            float somme;

            somme = a + b;

            // Affichage de la somme en convertissant les float en string .ToString()
            Console.Write("La somme des deux chiffres est : " + somme.ToString());
        }

        static void Multiplier(float a, float b)
        {
            
            float produit;

            produit = a * b;

            // Affichage du produit en convertissant les float en string .ToString()
            Console.Write("Le produit des deux chiffres est : " + produit.ToString());
        }

        #endregion
        

        static void Main(string[] args)
        {
            float a;
            float b;
            float resultat;
            string operateur;

            a = SaisirNombre("Saisir un nombre");
            operateur = Console.ReadLine();
            b = SaisirNombre("Saisir un second nombre");
            

            if (operateur == "+")
            {
                resultat = a + b;
                Console.Write("resultat : " + resultat.ToString());
            }

            if (operateur == "-")
            {
                resultat = a - b;
                Console.Write("resultat : " + resultat.ToString());
            }

            if (operateur == "*")
            {
                resultat = a * b;
                Console.Write("resultat : " + resultat.ToString());
            }

            if (operateur == "/")
            {
                resultat = a / b;
                Console.Write("resultat : " + resultat.ToString());
            }
        }
    }
}
