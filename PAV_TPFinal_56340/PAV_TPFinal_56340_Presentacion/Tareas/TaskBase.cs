using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Tareas;

public abstract class TaskBase : ITask
{
    public IView? MdiPadre { get; set; }
    public Navigator Navigator { get; set; }

    protected TaskBase(Navigator navigator)
    {
        Navigator = navigator;
        Navigator.Tarea = this;
    }

    public abstract void Iniciar();
    public void IniciarTarea<TTarea>(IView? mdiPadre = null)
        where TTarea : ITask
    {
        AdministradorDeTareas.Instance.Iniciar<TTarea>(mdiPadre);
    }

}
