
namespace Core.Entities;

    public class Pais:BaseEntity
    {
        public string NombrePais{ get; set;}
        public ICollection<Estado> Estados {get;set;} 
        
    }
