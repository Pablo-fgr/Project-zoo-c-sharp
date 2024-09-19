using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Tareas;

public interface ITask
{
    Navigator Navigator { get; set; }
    void Iniciar();
    void IniciarTarea<TTarea>(IView? MdiPadre = null)
        where TTarea : ITask;
}
