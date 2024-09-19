using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public interface IPresenter : IDisposable
{
    ITask? Tarea { get; set; }
    IView? Vista { get; set; }
}
