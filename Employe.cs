using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_emp
{
    public class Employe
    {

        private int matricule;
        private string nom;
        private string prenom;
        private DateTime datenaissance;
        private DateTime dateembauche;
        private DateTime dateconge;
        private double salaire;

        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime Datenaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }

        public DateTime Dateembauche
        {
            get { return dateembauche; }
            set { dateembauche = value; }
        }
        public DateTime Dateconge
        {
            get { return dateconge; }
            set { dateconge = value; }
        }

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public Employe(int m, string n, string p, DateTime dn, DateTime de, DateTime dc, double s)
        {
            matricule = m;
            nom = n;
            prenom = p;
            datenaissance = dn;
            dateembauche = de;
            dateconge =dc;
            salaire = s;
        }

        public int Age()
        {
            int age;
            age = DateTime.Now.Year - datenaissance.Year;
            if (datenaissance.AddYears(age) > DateTime.Now.Date)
                age--;
            return age;



        }

        public int Anciennete()
        {
            int Anc;
            Anc = DateTime.Now.Year - dateembauche.Year;
            if (dateembauche.AddYears(Anc) > DateTime.Now.Date)
            {
                Anc--;
            }
            /*else
            { 
                Anc++;
            }*/
            return Anc;

        }
       public int Conge() 
        {
            int cong;
            cong=DateTime.Now .Year-dateconge.Year;
            if (dateconge.AddYears(cong) < DateTime.Now.Date)
                cong++;
            return cong;
        }

        public void AugmentationDuSalaire()
        {
            if (Anciennete() < 5)
                salaire += salaire * 0.02;
            else if (Anciennete() < 10)
                salaire += salaire * 0.05;
            else
                salaire += salaire * 0.1;
        }

        public void AfficherEmploye()
        {
           Console.WriteLine("\n\nMatricule : " + matricule);
            Console.WriteLine("Nom Complet : " + nom.ToUpper() + " " + prenom.Substring(0, 1).ToUpper() + prenom.Substring(1).ToLower());
            Console.WriteLine("Age : " + Age());
            Console.WriteLine("Ancienneté : " + Anciennete());
            Console.WriteLine("votre date de congé est fixé dans:"+ Conge());
            Console.WriteLine("Salaire : " + salaire);
        }
    }
     
}
