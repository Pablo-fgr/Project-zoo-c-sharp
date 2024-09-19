using PAV_TPFinal_56340_Presentacion.Presentadores;
namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface IView<T> : IView where T : IPresenter
{
    new T? Presentador { get; set; }
}
