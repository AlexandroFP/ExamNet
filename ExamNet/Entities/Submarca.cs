public class Submarca
{
    public int SubmarcaId { get; set; }
    public int MarcaId { get; set; }
    public string Nombre { get; set; }
    public Marca Marca { get; set; }
    public ICollection<Modelo> Modelos { get; set; }
}