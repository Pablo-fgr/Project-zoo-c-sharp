namespace PAV_TPFinal_56340_Dominio.Entidades;

public class Carnivoro : Animal
{
    public Carnivoro() : base(TipoAlimentacion.CARNIVORO)
    {

    }
    public static double PorcentajeExtra { get; } = 0.1;
    public static double PesoMaximo { get; } = 500;
}
