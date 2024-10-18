using System.ComponentModel.DataAnnotations;

public class Estadio
{
    [Key]  
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Direccion { get; set; }

    [Required]
    [MaxLength(100)]
    public string Ciudad { get; set; }

    public int Capacidad { get; set; }
}
