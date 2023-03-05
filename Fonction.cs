using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_emp
{
    public class Fonction
    {
        private string nom_fonction;
        public string Nom_fonction
        { 
            get { return nom_fonction; }
            set { nom_fonction = value;}
        }
        public Fonction(string nf) 
        
        { 
            nom_fonction = nf;
        }
        public void AfficherFonction() 
        {
            Console.WriteLine("Fonction:"+nom_fonction);
        }
    }
}
