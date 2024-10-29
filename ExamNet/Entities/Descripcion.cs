public class Descripcion
{
    public Guid DescripcionId { get; set; }  
    public int ModeloId { get; set; }         
    public string TextoDescripcion { get; set; } 

    public Modelo Modelo { get; set; }
}
