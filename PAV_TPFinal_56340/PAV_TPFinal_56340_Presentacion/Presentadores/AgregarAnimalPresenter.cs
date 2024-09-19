using PAV_TPFinal_56340_Presentacion.Enums;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Dominio.Repositorios;
using PAV_TPFinal_56340_Presentacion.Tareas;

namespace PAV_TPFinal_56340_Presentacion.Presentadores;

public class AgregarAnimalPresenter : PresenterBase<AnimalTarea, IAgregarAnimalView>
{
    private readonly IRepositorio _repositorio;

    public AgregarAnimalPresenter(IAgregarAnimalView vista,
        AnimalTarea tarea, IRepositorio repositorio) : base(vista,tarea)
    {
        _repositorio = repositorio;
        Vista!.AgregarClicked += Vista_AgregarClicked;
        Vista!.CancelarClicked += Vista_CancelarClicked;
        Vista!.CargarEspecies(_repositorio.ListarTodos<Especie>());
        Vista!.CargarPaises(_repositorio.ListarTodos<Pais>());
        Vista!.CargarSectores(_repositorio.ListarTodos<Sector>(), 0);
    }

    private void Vista_AgregarClicked(object? sender, EventArgs e)
    {
        Vista!.ValidarCampos();
    }

    private void Vista_CancelarClicked(object? sender, EventArgs e)
    {
        if (Tarea == null) return;
        Vista!.Dispose();
        Tarea.Iniciar();
    }

    public void AgregarAnimal(string nombre, int edad, double peso, Guid idEspecie, Guid idPais, Guid idSector)
    {
        var especie = _repositorio.ObtenerPorId<Especie>(idEspecie);
        var paisOrigen = _repositorio.ObtenerPorId<Pais>(idPais);
        var sector = _repositorio.ObtenerPorId<Sector>(idSector);

        TipoAlimentacion tipoAlimentacion = especie!.TipoAlimentacion;
        Animal nuevoAnimal;

        if (sector!.TipoAlimentacion == especie.TipoAlimentacion && sector.Animales.Count < sector.Limite)
        {
            switch (tipoAlimentacion)
            {
                case TipoAlimentacion.CARNIVORO:
                    nuevoAnimal = new Carnivoro
                    {
                        Codigo = _repositorio.ListarTodos<Animal>().Count + 1,
                        Nombre = nombre,
                        Edad = edad,
                        Peso = peso,
                        Especie = especie,
                        PaisOrigen = paisOrigen!,
                        Sector = sector
                    };
                    break;

                case TipoAlimentacion.HERBIVORO:
                    nuevoAnimal = new Herbivoro
                    {
                        Codigo = _repositorio.ListarTodos<Animal>().Count + 1,
                        Nombre = nombre,
                        Edad = edad,
                        Peso = peso,
                        Especie = especie,
                        PaisOrigen = paisOrigen!,
                        Sector = sector
                    };
                    break;

                default:
                    throw new NotImplementedException();
            }

            if (Tarea == null) return;
            Tarea.ActualizarSector(idSector);
            _repositorio.Agregar(nuevoAnimal);
            Vista!.MostrarMensaje($"{nombre} ({especie.Nombre}) fue agregado con éxito!",Mensaje.EXITO);
        }
        else
        {
            Vista!.MostrarMensaje("No se pudo agregar el animal :(",Mensaje.ERROR);
        }
    }

    public Especie? ObtenerEspecie(Guid idEspecie)
    {
        return _repositorio.ObtenerPorId<Especie>(idEspecie);
    }

    // TODO: Despues sacar este metodo

    public Guid? ObtenerIdSector(int numero)
    {
        return _repositorio.ObtenerElPrimero<Sector>(s => s.Numero == numero)?.Id;
    }

    public List<Sector> ObtenerSectores()
    {
        return _repositorio.ListarTodos<Sector>();
    }
}
