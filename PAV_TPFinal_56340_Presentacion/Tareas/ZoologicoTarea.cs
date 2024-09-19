using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Tareas;

public class ZoologicoTarea : TaskBase
{
    public Guid SectorId { get; set; }
    public ZoologicoTarea(Navigator navigator) : base(navigator) { }

    public override void Iniciar()
    {
        Navigator.NavegarA<PrincipalPresenter>();
    }
}
