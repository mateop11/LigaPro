using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Equipo
{
    [Key]  // Llave primaria
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; }

    [Required]
    [MaxLength(100)]
    public string Ciudad { get; set; }

    public int Titulos { get; set; }

    public bool AceptaExtranjeros { get; set; }

    // ForeignKey a Estadio
    public int EstadioId { get; set; }

    [ForeignKey("EstadioId")]
    public Estadio Estadio { get; set; }

    // Relación uno a muchos con Jugador
    public ICollection<Jugador> Jugadores { get; set; }
}
