using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Dominio.Repositorios;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;
using PAV_TPFinal_56340_Presentacion.Vistas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class ZoologicoPresenter : PresenterBase<ZoologicoTarea, IZoologicoView>
{
    private readonly IRepositorio _repositorio;

    public ZoologicoPresenter(IZoologicoView vista,
        ZoologicoTarea tarea, IRepositorio repositorio) : base(vista,tarea)
    {
        _repositorio = repositorio;
        Vista!.AgregarAnimalClicked += Vista_AgregarAnimalClicked;
        Vista!.CargarSectores(_repositorio.ListarTodos<Sector>(nameof(Sector.Empleado), nameof(Sector.Animales)));
    }

    public void CalcularKgsComida(List<Sector> sectores)
    {
        double kgsCarnivoro = 0, kgsHerbivoro = 0, kgsTotales = 0;

        foreach(Sector s in sectores)
        {
            if (s.TipoAlimentacion == TipoAlimentacion.CARNIVORO)
                kgsCarnivoro += s.Animales
                    .Where(a => a.TipoAlimentacion == TipoAlimentacion.CARNIVORO)
                    .Sum(a => a.Peso * a.Especie.PorcentajePesoCarne);
            else
                kgsHerbivoro += s.Animales
                    .Where(a => a.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
                    .Sum(a => a.Peso);
        }

        kgsTotales = kgsCarnivoro + kgsHerbivoro;

        Vista!.CargarComida(kgsCarnivoro, kgsHerbivoro, kgsTotales);
    }

    public void MostrarInfoSector(object? sender, Guid idSector)
    {
        AdministradorDeTareas.Instance.Iniciar<ZoologicoTarea>();
        // Como hago para pasar el sector a la vista usando el Navigator?
        //Presentador!.Navigator!.NavegarA<SectorPresenter>();
        //var sectorView = new SectorView(s);
        //sectorView.MdiParent = MdiParent;
        //sectorView.Show();
        Tarea!.SectorId = idSector;
        Tarea!.Navigator.NavegarA<SectorPresenter>();
    }
    private void Vista_AgregarAnimalClicked(object? sender, EventArgs e)
    {
        var tarea = AdministradorDeTareas.Instance.Iniciar<AnimalTarea>();
        if (tarea == null) return;
        Vista!.Dispose();
        tarea.AnimalAgregado += Vista!.ActualizarSector;
        //Tarea.Iniciar();
    }

    public List<Animal> ObtenerAnimalesSector(Guid idSector)
    {
        var animales = _repositorio.Listar<Animal>(a => a.SectorId == idSector);
        foreach (var animal in animales)
        {
            animal.Especie = _repositorio.ObtenerPorId<Especie>(animal.EspecieId)!;
        }
        return animales;
    }
    public Empleado? ObtenerEmpleadoSector(Guid idEmpleado) => _repositorio.ObtenerElPrimero<Empleado>(e => e.Id == idEmpleado);
    public Sector? ObtenerSector(Guid idSector) => _repositorio.ObtenerPorId<Sector>(idSector);
}
