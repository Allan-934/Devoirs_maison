public class Etudiant
{
    private string nom;              // nom de ltudiant 
    private string prenom;           // prnom de ltudiant 
    private Projet[] tabProjets = new Projet[20]; // tableau des projets 
    private int nbProjets;           // nombre de projets 

    public void Init(string p_nom, string p_prenom) // initialisation d'un tudiant 
    {
        this.nom = p_nom;
        this.prenom = p_prenom;
        this.nbProjets = 0;
    }

    // Getters 
    public string GetNom()
    {
        return this.nom;
    }
    public string GetPrenom()
    {
        return this.prenom;
    }
    public int GetNbProjets()
    {
        return this.nbProjets;
    }

    // Setters
    public void SetNom(string p_nom)
    {
        this.nom = p_nom;
    }

    public void SetPrenom(string p_prenom)
    {
        this.prenom = p_prenom;
    }

    public void SetNbProjets(int p_nbProjets)
    {
        this.nbProjets = p_nbProjets;
    }   

    

    public void AjouterProjet(Projet p_leProjet) // Ajout du projet 
    {
        if (this.nbProjets < 20)
        {
            this.tabProjets[this.nbProjets] = p_leProjet;
            this.nbProjets++;
        }
    }

    public double GetMoyenne() // retourne la moyenne des notes 
    {
        if (this.nbProjets == 0) return 0;
        
        double somme = 0;
        for (int i = 0; i < this.nbProjets; i++)
        {
            somme += this.tabProjets[i].GetNote();
        }
        return somme / this.nbProjets;
    }

    public Projet MeilleurProjet() // retourne le projet avec la meilleure note [cite: 3, 6]
    {
        if (this.nbProjets == 0) return null;

        Projet meilleur = this.tabProjets[0];
        for (int i = 1; i < this.nbProjets; i++)
        {
            if (this.tabProjets[i].GetNote() > meilleur.GetNote())
            {
                meilleur = this.tabProjets[i];
            }
        }
        return meilleur;
    }
}