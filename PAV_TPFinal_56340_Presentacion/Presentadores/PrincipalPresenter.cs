using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class PrincipalPresenter : PresenterBase<ZoologicoTarea, IPrincipalView>
{
    public PrincipalPresenter(IPrincipalView vista, ZoologicoTarea tarea) : base(vista,tarea)
    {
        Vista!.VerZooClicked += Vista_VerZooClicked;
        Vista!.AgregarAnimalClicked += Vista_AgregarAnimalClicked;
    }

    private void Vista_VerZooClicked(object? sender, EventArgs e)
    {
        Tarea!.Navigator.NavegarA<ZoologicoPresenter>();
    }
    private void Vista_AgregarAnimalClicked(object? sender, EventArgs e)
    {
        Tarea!.Navigator.NavegarA<AgregarAnimalPresenter>(true);
    }
}
