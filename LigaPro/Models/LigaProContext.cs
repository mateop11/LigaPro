using Microsoft.EntityFrameworkCore;

public class LigaProContext : DbContext
{
    public LigaProContext(DbContextOptions<LigaProContext> options) : base(options)
    {
    }

    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Jugador> Jugadores { get; set; }
    public DbSet<Estadio> Estadios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relación uno a muchos: Equipo - Jugador
        modelBuilder.Entity<Jugador>()
            .HasOne(j => j.Equipo)
            .WithMany(e => e.Jugadores)
            .HasForeignKey(j => j.EquipoId);

        // Relación uno a uno: Equipo - Estadio
        modelBuilder.Entity<Equipo>()
            .HasOne(e => e.Estadio)
            .WithMany()
            .HasForeignKey(e => e.EstadioId);
    }
}
