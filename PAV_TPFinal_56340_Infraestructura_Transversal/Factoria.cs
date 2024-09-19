using Microsoft.Extensions.DependencyInjection;

namespace PAV_TPFinal_56340_Infraestructura_Transversal;

public class Factoria
{
    private static volatile Factoria? _instance;
    private static readonly object _syncLock = new();
    
    private ServiceProvider? _container;

    private Factoria()
    {

    }

    public static Factoria Instance
    {
        get
        {
            lock (_syncLock)
            {
                return _instance ??= new Factoria();
            }
        }
    }

    public void SetContenedor(ServiceProvider container)
    {
        _container = container;
    }

    public T? Crear<T>()
    {
        return _container!.GetService<T>();
    }

}
