using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface IControl
{
    IPresenter? Presentador { get; set; }
}
