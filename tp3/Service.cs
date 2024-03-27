using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace tp3
{
    internal class Service
    {
        private string nomService;
        private Commerciale[] tableau;
        private int effectif;

        public string NomService { get => nomService; set => nomService = value; }
        public int Effectif { get => effectif; set => effectif = value; } 
        internal Commerciale[] Tableau { get => tableau; set => tableau = value; }

        public Service(string nomService) 
        { 
            this.nomService = nomService;
            effectif = 0;
            tableau = new Commerciale[1];
        }

        public Service() { }

        public void ajouterCom(Commerciale c)
        {
            tableau[this.effectif] = c;
            this.effectif++;
        }

        public Commerciale CommercialeLePlusAge()
        {
            Commerciale plusAge = null;
            foreach (Commerciale c in tableau)
            {
                if (c != null && (plusAge == null || c.calculAge() > plusAge.calculAge()))
                {
                    plusAge = c;
                }
            }
            return plusAge;
        }

        public override string ToString()
        {
            string result = "Service : " + NomService + "\n";
            result += "Commerciaux: \n";
            foreach (Commerciale c in tableau)
            {
                if (c != null)
                {
                    result += c.ToString() + "\n";
                }
            }
            result += "Effectif " + Tableau.Length + "\n";

            Commerciale plusAge = CommercialeLePlusAge();
            if (plusAge != null)
            {
                result += "Commerciale le plus agé du service : \n" + plusAge.ToString() + "\n";
            }
            else
            {
                result += "Pas de commerciale dans ce service \n";
            }
            return result;
        }
    }
}
