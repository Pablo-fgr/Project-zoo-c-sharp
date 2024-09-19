using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class PresenterBase : IPresenter
{
    public virtual ITask? Tarea  { get; set; }
    public virtual IView? Vista { get; set; }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            Vista?.Dispose();
        }
    }
}
