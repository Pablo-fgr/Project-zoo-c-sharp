namespace PAV_TPFinal_56340_Dominio.Entidades;

public class Especie : EntityBase
{
    public required int Codigo { get; init; }
    public required string Nombre { get; init; }
    public double PorcentajePesoCarne { get; init; }
    public required TipoAlimentacion TipoAlimentacion { get; init; }
}
