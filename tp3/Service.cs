using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Service(string nomService, Commerciale[] tabcom, int effectif) 
        { 
            this.nomService = nomService;
            Tableau = tabcom;
            this.effectif = effectif;
            effectif = 0;
            tabcom = new Commerciale[10];
        }

        public Service() { }
    }
}
