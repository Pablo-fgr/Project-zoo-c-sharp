namespace PAV_TPFinal_56340_Dominio.Entidades;

public abstract class Animal : EntityBase
{
    protected Animal(TipoAlimentacion tipoAlimentacion)
    {
        TipoAlimentacion = tipoAlimentacion;
    }
    public required int Codigo { get; set; }
    public required string Nombre { get; set; }
    public required int Edad { get; set; }
    public required double Peso { get; set; }
    public TipoAlimentacion TipoAlimentacion { get; }
    public Guid PaisId { get; set; }
    public required Pais PaisOrigen { get; set; }
    public Guid EspecieId { get; set; }
    public required Especie Especie { get; set; }
    public Guid SectorId { get; set; }
    public required Sector Sector { get; set; }

}
