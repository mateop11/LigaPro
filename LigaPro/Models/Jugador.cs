using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Jugador
{
    [Key]  // Llave primaria
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public string Posicion { get; set; }

    public int Edad { get; set; }

    // ForeignKey a Equipo
    public int EquipoId { get; set; }

    [ForeignKey("EquipoId")]
    public Equipo Equipo { get; set; }
}
