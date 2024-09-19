namespace PAV_TPFinal_56340_Dominio.Entidades;

public class Herbivoro : Animal
{
    public Herbivoro() : base(TipoAlimentacion.HERBIVORO)
    {

    }

    public static double PorcentajePeso { get; } = 2;
    public double ValorFijo { get; set; }
}
