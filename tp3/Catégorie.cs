using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    internal class Catégorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Catégorie(string codeCategorie, string libCategorie) 
        { 
            this.CodeCategorie = codeCategorie;
            this.libCategorie = libCategorie;
        }

        public Catégorie() { }

        public override string ToString()
        {
            return "code :" + codeCategorie + "\n  libellé :" + libCategorie;
        }
    }
}
