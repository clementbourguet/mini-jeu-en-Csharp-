using System;

namespace JeuRole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            int niveau = 1;
            bool quitter = false;

            while (!monPerso.EstMort() && !quitter)
            {
                Monstre monstre = Monstre.CreateRandom();
                bool victoire = true;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Un ennemi apparaît : {monstre.GetNom()}"); 
                Console.WriteLine();

                // Combat jusqu'à la mort du monstre ou du joueur
                while (!monstre.EstMort() && !monPerso.EstMort())
                {
                    // Tour du Monstre
                    Console.ForegroundColor = ConsoleColor.Red;
                    monstre.Attaquer(monPerso);
                    Console.WriteLine();
                    Console.ReadKey(true);

                    if (monPerso.EstMort())
                    {
                        victoire = false;
                        break;
                    }

                    // Tour du Personnage
                    Console.ForegroundColor = ConsoleColor.Green;
                    monPerso.Attaquer(monstre);
                    Console.WriteLine();
                    Console.ReadKey(true);
                }

                if (victoire)
                {
                    monPerso.gagnerExperience(5);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine(monPerso.Caracteristiques());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();

                    // Demander si on continue au niveau suivant
                    Console.WriteLine("Salle suivante ? (O/N)");
                    string saisie = Console.ReadLine().ToUpper();
                    if (saisie == "O")
                    {
                        niveau++;
                        Console.Clear();
                        continue; // nouveau monstre au niveau supérieur
                    }
                    else
                    {
                        quitter = true;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("C'est perdu ! ");
                    Console.ReadKey();
                    break;
                }
            }

            // Fin de la boucle : retour au menu ou quitter
            Menu();
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Le JEU");
            Console.WriteLine();
            Console.WriteLine("Choisis ta classe : ");
            Console.WriteLine("1. Guerrier ");
            Console.WriteLine("2. Sorcier ");
            Console.WriteLine("3. Archer ");
            Console.WriteLine("4. Quitter ");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisi Guerrier !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Ragnar"));
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisi Sorcier !");
                    Console.WriteLine();
                    Jouer(new Sorcier("Merlin"));
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisi Archer !");
                    Console.WriteLine();
                    Jouer(new Archer("Tyros"));
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    Menu();
                    break;
            }
        }
    }
}
