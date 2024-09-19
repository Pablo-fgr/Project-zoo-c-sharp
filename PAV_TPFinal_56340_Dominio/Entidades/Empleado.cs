namespace PAV_TPFinal_56340_Dominio.Entidades;

public class Empleado : EntityBase
{
    public required string Nombre { get; set; }

    public required string Dni { get; set; }

    public required string Domicilio { get; set; }
}
