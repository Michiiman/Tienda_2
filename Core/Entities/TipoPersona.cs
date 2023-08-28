namespace Core.Entities;

public class TipoPersona
{
    public int IdTPersona {get;set;} 
    public string Descripcion {get;set;}
    public ICollection<Persona> Personas{get;set;}
    
}
