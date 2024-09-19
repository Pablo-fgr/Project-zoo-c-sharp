using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Dominio.Repositorios;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class ZoologicoPresenter : PresenterBase<ZoologicoTarea, IZoologicoView>
{
    private readonly IRepositorio _repositorio;

    public ZoologicoPresenter(IZoologicoView vista,
        ZoologicoTarea tarea, IRepositorio repositorio) : base(vista,tarea)
    {
        _repositorio = repositorio;
        Vista!.AgregarAnimalClicked += Vista_AgregarAnimalClicked;
        Vista!.CalcComidaClicked += CalcularKgsComida;
        Vista!.CargarSectores(ObtenerSectores());
    }

    public void CalcularKgsComida(object? sender, EventArgs e)
    {
        double kgsCarnivoro = 0, kgsHerbivoro = 0, kgsTotales = 0;
        var sectores = _repositorio.ListarTodos<Sector>();

        sectores.ForEach(s =>
        {
            s.Animales = _repositorio.Listar<Animal>(a => a.SectorId == s.Id, nameof(Animal.Especie));

            if (s.TipoAlimentacion == TipoAlimentacion.CARNIVORO)
                kgsCarnivoro += s.Animales
                    .Where(a => a.TipoAlimentacion == TipoAlimentacion.CARNIVORO)
                    .Sum(a => a.Peso * a.Especie.PorcentajePesoCarne);
            else
                kgsHerbivoro += s.Animales
                    .Where(a => a.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
                    .Sum(a => a.Peso);
        });

        kgsTotales = kgsCarnivoro + kgsHerbivoro;

        Vista!.CargarComida(kgsCarnivoro, kgsHerbivoro, kgsTotales);
    }

    public void MostrarInfoSector(object? sender, Guid idSector)
    {
        Tarea!.SectorId = idSector;
        Tarea!.Navigator.NavegarA<SectorPresenter>(true);
    }
    public Sector? ObtenerSector(Guid idSector) => _repositorio.ObtenerPorId<Sector>(idSector);

    private List<Sector> ObtenerSectores()
    {
        var sectores = _repositorio.ListarTodos<Sector>(nameof(Sector.Empleado), nameof(Sector.Animales));
        sectores.ForEach(s => s.Animales.ForEach(a =>
        {
            a.Especie = _repositorio.ObtenerPorId<Especie>(a.EspecieId)!;
            a.PaisOrigen = _repositorio.ObtenerPorId<Pais>(a.PaisId)!;
        }));

        return sectores.OrderBy(s => s.Numero).ToList();
    }
    private void Vista_AgregarAnimalClicked(object? sender, EventArgs e)
    {
        Tarea!.Navigator.NavegarA<AgregarAnimalPresenter>(true);
        Vista!.CargarSectores(ObtenerSectores());
    }
}
