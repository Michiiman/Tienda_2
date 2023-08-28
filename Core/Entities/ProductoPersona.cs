namespace Core.Entities;

public class ProductoPersona
{
    public int IdProductoFk{ get; set; }
    public Producto Producto{ get; set; }
    public int IdPersonaFk{ get; set; }
    public Persona Persona{ get; set; }
   
    
}
