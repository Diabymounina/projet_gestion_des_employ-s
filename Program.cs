
using gestion_emp;

class Program
{
    static void Main(string[] args)
    {
        int mat;
        string nom, prenom;
        DateTime dn, de, dc;
        double salaire;
        string ns;
        string nf;
        int nbr_employe;
        Console.WriteLine("donner le nombre employes");
        nbr_employe = int.Parse(Console.In.ReadLine());
        for (int i = 0; i <= nbr_employe; i++)
        {
        Console.Write("Matricule: ");
        mat = int.Parse(Console.In.ReadLine());
        Console.Write("Nom: ");
        nom = Console.In.ReadLine();
        Console.Write("Prénom: ");
        prenom = Console.In.ReadLine();
        Console.Write("Date de naissance (jj/mm/aaaa): ");
        dn = DateTime.Parse(Console.In.ReadLine());
        Console.Write("Date embauche (jj/mm/aaaa): ");
        de = DateTime.Parse(Console.In.ReadLine());
        Console.Write("Date dernier congé (jj/mm/aaaa): ");
        dc = DateTime.Parse(Console.In.ReadLine());
        Console.Write("salaire: ");
        salaire = double.Parse(Console.In.ReadLine());
        Console.Write("Service:");
        ns  = Console.In.ReadLine();
        Console.Write("Fonction:");
        nf = Console.In.ReadLine();
           Employe e = new Employe(mat, nom, prenom, dn, de, dc, salaire);
           Service s = new Service(ns);
            Fonction f = new(nf);
            Console.WriteLine("\n\n Avant augmentation de la salaire");
            e.AfficherEmploye();
            s.AfficherService();
            f.AfficherFonction();
            Console.WriteLine("\n\nAprés application de l'augmentation de salaire");
            e.AugmentationDuSalaire();
            e.AfficherEmploye();
            s.AfficherService();
            f.AfficherFonction();



        }

        Console.ReadKey();
    }
}