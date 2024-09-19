using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Vistas.Controles;

public abstract class ControlBase<T> : ControlBase, IControl<T>
    where T : class, IPresenter
{
    public new T? Presentador { get; set; }
    IPresenter? IControl.Presentador
    {
        get { return Presentador; }
        set { Presentador = value as T; }
    }
}
