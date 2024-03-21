using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    internal class Commerciale
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;
        private Catégorie categorie;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        internal Catégorie Categorie { get => categorie; set => categorie = value; }

        public Commerciale(string nom, string prenom, int anneeNaissance, Catégorie categorie)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeNaissance = anneeNaissance;
            this.categorie = categorie;

        }

        public Commerciale() { }

        public int calculAge()
        {
            int age = DateTime.Now.Year - this.anneeNaissance;
            return age;
        }

        public override string ToString()
        {
            return "nom : " + nom + "\n prenom : " + prenom + "\n Année de Naissance : " + calculAge() + " ans \n " +this.categorie+ "\n";
        }

        public void Compare(Commerciale autreCommercial)
        {
            if (nom == autreCommercial.nom)
            {
                Console.WriteLine($"Les commerciaux {this.Nom} et {autreCommercial.Nom} ont le même nom de famille.");
            }
            else
            {
                Console.WriteLine($"Les commerciaux {this.Nom} et {autreCommercial.Nom} n'ont pas le même nom de famille.");
            }
        }
    }
}
