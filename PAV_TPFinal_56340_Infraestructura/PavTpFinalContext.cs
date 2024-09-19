    using Microsoft.EntityFrameworkCore;
using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Infraestructura_Datos.Datos;

namespace PAV_TPFinal_56340_Infraestructura_Datos;

public class PavTpFinalContext : DbContext
{
    public const string CadenaDeConexion = "Server=(localdb)\\MSSQLLocalDB;Database=PavFinal";
    public DbSet<Animal> Animales { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Especie> Especies { get; set; }
    public DbSet<Sector> Sectores { get; set; }

    public PavTpFinalContext(DbContextOptions<PavTpFinalContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SectorConfig(modelBuilder);
        PaisConfig(modelBuilder);
        EmpleadoConfig(modelBuilder);
        EspecieConfig(modelBuilder);
        AnimalConfig(modelBuilder);
    }

    private void SectorConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sector>()
            .ToTable("Sectores")
            .Property(p => p.Latitud).HasPrecision(10,8);
        modelBuilder.Entity<Sector>()
            .Property(p => p.Longitud).HasPrecision(10,8);

        modelBuilder.Entity<Sector>()
            .HasData(Iniciales.Instance.Sectores.ToArray());
    }

    private void PaisConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pais>()
            .ToTable("Paises")
            .Property(p => p.Nombre).HasMaxLength(100).IsRequired();

        modelBuilder.Entity<Pais>()
            .HasData(Iniciales.Instance.Paises.ToArray());
    }

    private void EmpleadoConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>()
            .ToTable("Empleados")
            .Property(p => p.Nombre).HasMaxLength(80).IsRequired();
        modelBuilder.Entity<Empleado>()
            .Property(p => p.Domicilio).HasMaxLength(100);
        modelBuilder.Entity<Empleado>()
            .Property(p => p.Dni).HasMaxLength(8).IsRequired();

        modelBuilder.Entity<Empleado>()
            .HasData(Iniciales.Instance.Empleados.ToArray());
    }

    private void EspecieConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Especie>()
            .ToTable("Especies")
            .Property(p => p.Nombre).HasMaxLength(50).IsRequired();

        modelBuilder.Entity<Especie>()
            .HasData(Iniciales.Instance.Especies.ToArray());
    }

    private void AnimalConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>()
            .ToTable("Animales")
            .HasDiscriminator(p => p.TipoAlimentacion)
            .HasValue<Carnivoro>(TipoAlimentacion.CARNIVORO)
            .HasValue<Herbivoro>(TipoAlimentacion.HERBIVORO);
    }
}
