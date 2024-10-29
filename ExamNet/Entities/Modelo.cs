public class Modelo
{
    public int ModeloId { get; set; }        
    public int SubmarcaId { get; set; }     
    public int Año { get; set; }              

    public Submarca Submarca { get; set; }

    public ICollection<Descripcion> Descripciones { get; set; }
}
