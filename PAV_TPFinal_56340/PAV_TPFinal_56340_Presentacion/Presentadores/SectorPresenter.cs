using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Dominio.Repositorios;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;
using PAV_TPFinal_56340_Presentacion.Vistas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class SectorPresenter : PresenterBase<ZoologicoTarea, ISectorView>
{
    private readonly IRepositorio _repositorio;
    public SectorPresenter(ISectorView vista,
        ZoologicoTarea tarea, IRepositorio repositorio) : base(vista,tarea)
    {
        _repositorio = repositorio;
        Vista!.RellenarInfoSector(_repositorio.ObtenerPorId<Sector>(Tarea!.SectorId)!);
        //control.SectorClicked += MostrarInfoSector;
    }

    //public List<Animal> ObtenerAnimalesSector(Guid idSector) => _repositorio.Listar<Animal>(a => a.SectorId == idSector);
    //public Empleado? ObtenerEmpleadoSector(Guid idEmpleado) => _repositorio.ObtenerElPrimero<Empleado>(e => e.Id == idEmpleado);
    public Sector? ObtenerSector(Guid idSector) => _repositorio.ObtenerPorId<Sector>(idSector);
}
