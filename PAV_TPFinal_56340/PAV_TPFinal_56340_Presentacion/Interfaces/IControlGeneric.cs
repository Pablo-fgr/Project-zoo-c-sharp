using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface IControl<T> : IControl where T : IPresenter
{
    new T? Presentador { get; set; }
}
