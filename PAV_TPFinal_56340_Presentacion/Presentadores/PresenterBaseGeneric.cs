using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;
using System.Windows.Markup;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class PresenterBase<TTask, TView> : IPresenter<TTask, TView>
    where TTask : class, ITask
    where TView : class, IView
{
    public virtual TTask? Tarea { get; set; }
    public virtual TView? Vista { get; set; }

    ITask? IPresenter.Tarea
    {
        get { return Tarea; }
        set { Tarea = value as TTask; }
    }
    IView? IPresenter.Vista
    {
        get { return Vista; }
        set { Vista = value as TView; }
    }

    public PresenterBase(TView vista, TTask tarea)
    {
        Vista = vista;
        Vista.Presentador = this;
        Vista.VistaClosed += Vista_VistaClosed;
        Tarea = tarea;
    }

    private void Vista_VistaClosed(object? sender, EventArgs e)
    {
        Dispose();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if(disposing)
        {
            Vista = null;
        }
    }
}
