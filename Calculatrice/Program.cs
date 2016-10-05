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

        static void Addition(float a, float b)
        {
            float somme;

            somme = a + b;

            // Affichage de la somme en convertissant les float en string .ToString()
            Console.Write("La somme des deux chiffres est : " + somme.ToString());
        }

        static void Soustraction(float a, float b)
        {
            float resultat;

            resultat = a - b;

            // Affichage du produit en convertissant les float en string .ToString()
            Console.Write("Le resultat des deux chiffres est : " + resultat.ToString());
        }

        static void Multiplication(float a, float b)
        {
            float produit;

            produit = a * b;

            // Affichage du produit en convertissant les float en string .ToString()
            Console.Write("Le produit des deux chiffres est : " + produit.ToString());
        }

        static void Division(float a, float b)
        {
            float resultat;
            
            if (a != 0 && b != 0)
            {
                resultat = a / b;
                // Affichage du produit en convertissant les float en string .ToString()
                Console.Write("Le résultat des deux chiffres est : " + resultat.ToString());
            }
            else
            {
                Console.WriteLine("PAS POSSIBLE DE DIVISER PAR 0 !!!!!");
            }
        }

        #endregion


        static void Main(string[] args)
        {
            float a;
            float b;
            string operateur;

            a = SaisirNombre("Saisir un nombre");
            operateur = Console.ReadLine();
            b = SaisirNombre("Saisir un second nombre");
            

            if (operateur == "+")
            {
                Addition(a, b);
            }

            if (operateur == "-")
            {
                Soustraction(a, b);
            }

            if (operateur == "*")
            {
                Multiplication(a, b);
            }

            if (operateur == "/")
            {
                Division(a, b);
            }
        }
    }
}
