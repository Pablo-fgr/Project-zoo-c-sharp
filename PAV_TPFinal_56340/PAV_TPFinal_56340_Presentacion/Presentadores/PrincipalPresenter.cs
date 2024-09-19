using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class PrincipalPresenter : PresenterBase<PrincipalTarea, IPrincipalView>
{
    public PrincipalPresenter(IPrincipalView vista, PrincipalTarea tarea) : base(vista,tarea)
    {
        Vista!.VerZooClicked += Vista_VerZooClicked;
        Vista!.AgregarAnimalClicked += Vista_AgregarAnimalClicked;
    }

    private void Vista_VerZooClicked(object? sender, EventArgs e)
    {
        AdministradorDeTareas.Instance.Iniciar<ZoologicoTarea>(Vista);
        //AdministradorDeTareas.Instance.Iniciar<SectorTarea>(Vista);
        //Tarea!.IniciarTarea<ZoologicoTarea>(Vista);
    }
    private void Vista_AgregarAnimalClicked(object? sender, EventArgs e)
    {
        AdministradorDeTareas.Instance.Iniciar<AnimalTarea>(Vista);
        //Tarea!.IniciarTarea<AnimalTarea>(Vista);
    }
}
