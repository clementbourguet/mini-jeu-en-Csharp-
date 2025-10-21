using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRole
{
    public class Monstre : Entite
    {
        private static readonly string[] Noms = new[]
        {
            "Loup enragé",
            "Gobelin visqueux",
            "Elfe des bois hantés",
            "Géant des collines",
            "Orc sauvage",
            "Archer zombie",
            "Troll venimeux"
        };

        private static readonly Random rnd = new Random();

        // Constructeur simple : stats fixes (pas d'évolution)
        public Monstre(string name) : base(name)
        {
            
            // Stats fixes
            this.pointsDeVie = 60;
            this.degatsMin = 5;
            this.degatsMax = 10;
        }

        // Fabrique un monstre avec nom aléatoire
        public static Monstre CreateRandom()
        {
            string name = Noms[rnd.Next(Noms.Length)];
            return new Monstre(name);
        }

        // Accesseur public pour le nom
        public string Nom
        {
            get { return this.nom; }
        }
    }
}