using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Tareas;

public class SectorTarea : TaskBase
{
    //public Guid SectorId { get; set; }
    //public event Action<Guid>? SectorElegido;
    public SectorTarea(Navigator navigator) : base(navigator) { }

    public override void Iniciar()
    {
        Navigator.NavegarA<SectorPresenter>();
    }
}
