public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string Plan { get; set; } // Básico, Premium, etc.
    public List<Libro> LibrosLeidos { get; set; }
}