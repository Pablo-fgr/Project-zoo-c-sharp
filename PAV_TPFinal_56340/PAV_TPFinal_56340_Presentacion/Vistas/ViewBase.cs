using PAV_TPFinal_56340_Presentacion.Enums;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Vistas;
public abstract class ViewBase : Form, IView
{
    public virtual IPresenter? Presentador { get; set; }
    public bool IsMdiPadre => IsMdiContainer;
    public event EventHandler? VistaClosed;

    protected ViewBase()
    {
        FormClosed += ViewBase_FormClosed;
    }

    public void Mostrar(IView? padre = null)
    {
        if(padre != null && !IsMdiContainer)
        {
            MdiParent = (Form)padre;
        }
        Show();
    }

    public void MostrarComoDialogo() => ShowDialog();

    public void MostrarMensaje(string mensaje, Mensaje tipoMensaje)
    {
        MessageBox.Show(mensaje,tipoMensaje.ToString(),MessageBoxButtons.OK,EstablecerIcono(tipoMensaje));
    }
    public bool MostrarConfirmacion(string mensaje)
    {
        return MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }

    private MessageBoxIcon EstablecerIcono(Mensaje tipoMensaje)
    {
        return tipoMensaje switch
        {
            Mensaje.EXITO => MessageBoxIcon.Information,
            Mensaje.ADVERTENCIA => MessageBoxIcon.Warning,
            _ => MessageBoxIcon.Error
        };
    }

    private void ViewBase_FormClosed(object? sender, FormClosedEventArgs e)
    {
        VistaClosed?.Invoke(this,e);
        Presentador = null;
        Dispose();
    }
}
