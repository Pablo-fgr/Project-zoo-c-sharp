namespace PAV_TPFinal_56340_Dominio.Entidades;

public class Sector : EntityBase
{ 
    public required int Numero { get; set; }
    public required double Latitud { get; set; }
    public required double Longitud { get; set; }
    public required int Limite { get; set; }
    public required TipoAlimentacion TipoAlimentacion { get; set; }
    public Guid EmpleadoId { get; set; }
    public Empleado? Empleado { get; set; }
    public List<Animal> Animales { get; set; } = new List<Animal>();
    public string DistinguirAnimales()
    {
        List<string> especies = new();

        foreach (Animal animal in Animales)
        {
            especies.Add(animal.Especie.Nombre);
        }

        return (especies.Count > 0) ? string.Join(", ", especies.Distinct()) : "No hay especies";
    }
}
