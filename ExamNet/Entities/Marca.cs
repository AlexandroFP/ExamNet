public class Marca
{
    public int MarcaId { get; set; }
    public string Nombre { get; set; }
    public ICollection<Submarca> Submarcas { get; set; }
}
