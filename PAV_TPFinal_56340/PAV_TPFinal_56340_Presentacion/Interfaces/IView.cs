using PAV_TPFinal_56340_Presentacion.Enums;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface IView : IDisposable
{
    bool IsMdiPadre { get; }
    event EventHandler? VistaClosed;
    IPresenter? Presentador { get; set; }

    void MostrarMensaje(string mensaje, Mensaje tipoMensaje);
    void Mostrar(IView? padre = null);
    void MostrarComoDialogo();
    bool MostrarConfirmacion(string mensaje);
}
