using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Vistas.Controles;

public abstract class ControlBase : UserControl, IControl
{
    public virtual IPresenter? Presentador { get; set; }
    protected ControlBase()
    {
    }
}
