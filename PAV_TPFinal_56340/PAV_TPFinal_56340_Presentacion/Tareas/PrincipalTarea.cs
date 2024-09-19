using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Tareas;

public class PrincipalTarea : TaskBase
{
    public PrincipalTarea(Navigator navigator) : base(navigator) { }

    public override void Iniciar()
    {
        Navigator.NavegarA<PrincipalPresenter>();
    }
}
