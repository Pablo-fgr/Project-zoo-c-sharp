using PAV_TPFinal_56340_Infraestructura_Transversal;
using PAV_TPFinal_56340_Presentacion.Interfaces;

namespace PAV_TPFinal_56340_Presentacion.Tareas;

public class AdministradorDeTareas
{
    private static volatile AdministradorDeTareas? _instance;
    private static readonly object _syncLock = new();

    private AdministradorDeTareas()
    {

    }

    public static AdministradorDeTareas Instance
    {
        get
        {
            lock (_syncLock)
            {
                return _instance ??= new AdministradorDeTareas();
            }
        }
    }

    public TTarea? Iniciar<TTarea>(IView? mdiPadre = null)
        where TTarea : ITask
    {
        var tarea = Factoria.Instance.Crear<TTarea>();
        if (tarea == null) return default;
        tarea.Navigator.MdiPadre = mdiPadre;
        tarea.Iniciar();
        return tarea;
    }
}
