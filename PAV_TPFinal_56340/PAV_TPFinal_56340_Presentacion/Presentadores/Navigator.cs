using PAV_TPFinal_56340_Infraestructura_Transversal;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public sealed class Navigator
{
    public IView? MdiPadre { get; set; }
    public ITask? Tarea { get; set; }
    public void NavegarA<TPresentador>(bool esDialogo = false) where TPresentador : IPresenter
    {
        var presentador = Factoria.Instance.Crear<TPresentador>();
        if (presentador is null || presentador.Vista is null) return;
        if (MdiPadre is null && presentador.Vista.IsMdiPadre)
            MdiPadre = presentador.Vista;
        Tarea = presentador.Tarea;
        if (esDialogo)
        {
            presentador.Vista.MostrarComoDialogo();
        }
        else
        {
            presentador.Vista.Mostrar(MdiPadre);
        }
    }
}
