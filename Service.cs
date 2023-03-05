using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_emp
{
    public class Service
    {
        private string nom_service;
        public string Nom_service
        {
            get { return nom_service; }
            set { nom_service = value; }
        }
        public Service(string ns) 
        { 
            nom_service = ns;
        }
        public void AfficherService() 
        {
            Console.WriteLine("Service:"+nom_service);
        }
    }
}
