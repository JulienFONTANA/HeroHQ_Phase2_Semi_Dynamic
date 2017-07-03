using System.Data.Entity;

namespace BestSiteEver.Models
{
    // Classe Context
    // Un "context" est comme son nom l'indique l'ensemble des
    // éléments utilisé par votre programme pour fonctionner
    // Plus précisément, un context en informatique est souvent
    // utilisé pour faire référance à la base de données
    public class Context : DbContext
    {
        // DbSet est une collection qui agit comme une basse de donnée et qui
        // est utilisée par EntityFramework
        public DbSet<Hero> Heroes { get; set; }
    }
}