using PAV_TPFinal_56340_Presentacion.Presentadores;
using PAV_TPFinal_56340_Presentacion.Vistas.Controles;

namespace PAV_TPFinal_56340_Presentacion.Tareas;

public class AnimalTarea : TaskBase
{
    public event Action<Guid>? AnimalAgregado;
    public AnimalTarea(Navigator navigator) : base(navigator)
    {

    }

    public void ActualizarSector(Guid idSector)
    {
        if (AnimalAgregado == null) return;
        AnimalAgregado.Invoke(idSector);
    }

    public override void Iniciar()
    {
        Navigator.NavegarA<AgregarAnimalPresenter>();
    }

}
