namespace Core.Entities;

public class Persona : BaseEntity
{
    public string IdPersona{ get; set;}
    public string NombrePersona { get; set;}
    public DateTime FechaNac{ get; set;}
    public int IdTipoPerFk { get; set;}
    public TipoPersona TipoPersona{ get; set;}
    public int IdRegionFk{ get; set;}
    public Region Region { get; set;}
    public ICollection<Producto> Productos{ get; set;}= new HashSet<Producto>();
    public ICollection<ProductoPersona> ProductosPersonas{ get; set;}


    
}