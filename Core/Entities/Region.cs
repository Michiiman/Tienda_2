namespace Core.Entities;

    public class Region:BaseEntity
    {
        public string NombreRegion{ get; set; }
        public int IdEstadoFk{ get; set; }
        public Estado Estado{ get; set; }
        public ICollection<Persona>  Personas{ get; set; }
        
    }
    
