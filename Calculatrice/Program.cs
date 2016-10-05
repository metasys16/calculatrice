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
            
            if (b != 0) // Si l'utilisateur tente de diviser par 0
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

        #region affichage

        static float SaisirNombre(string prompt)
        {
            string reponse;

            Console.WriteLine(prompt);
            reponse = Console.ReadLine();
            return float.Parse(reponse); // Convertir une String en Float
        }

        static void Menu()
        {
            float a;
            float b;
            string operateur;
            bool sortie;
            string caractere_sortie;

            sortie = false;
            
            // Tant que l'utilisateur ne veut pas sortir du programme
            while(sortie == false)
            {
                a = SaisirNombre("Saisir un nombre");
                Console.WriteLine("Choisissez un opérateur : + ; - ; * ; / ; ");
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

                // options fin d'opération
                Console.WriteLine();
                Console.WriteLine("Appuyez sur Entrée pour continuer");
                Console.WriteLine("Appuyez sur 'q' pour sortir");
                caractere_sortie = Console.ReadLine();

                // Si l'utilisateur appuie sur la touche "q" il pourra sortir du programme
                if (caractere_sortie == "q")
                {
                    sortie = true; // quit programme
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {            
            Menu();
        }
    }
}
