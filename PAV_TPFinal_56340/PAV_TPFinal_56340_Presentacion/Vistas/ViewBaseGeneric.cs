using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Vistas;

public abstract class ViewBase<T> : ViewBase, IView<T>
    where T : class, IPresenter
{
    public new T? Presentador { get; set; }

    IPresenter? IView.Presentador
    {
        get { return Presentador; }
        set { Presentador = value as T; }
    }
}
