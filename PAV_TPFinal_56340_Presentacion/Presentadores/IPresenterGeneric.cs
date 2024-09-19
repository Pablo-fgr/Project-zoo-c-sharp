using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public interface IPresenter<TTask, TView> : IPresenter
    where TTask : ITask
    where TView : IView
{
    new TTask? Tarea { get; set; }
    new TView? Vista { get; set; }
}
