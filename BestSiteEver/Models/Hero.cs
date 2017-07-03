using System.ComponentModel.DataAnnotations;

namespace BestSiteEver.Models
{
    // Classe "Hero", elle représente notre modèle dans la base de donnée.
    public class Hero
    {
        // [Key] est une annotation pour signaler à EntityFramework
        // que le champ Id est une clé primaire.
        // Une clé primaire à une valeure unique pour chaque entrée
        // dans la base de données.
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Pouvoir { get; set; }
        public string Citation { get; set; }
        public string Photo { get; set; }
    }
}