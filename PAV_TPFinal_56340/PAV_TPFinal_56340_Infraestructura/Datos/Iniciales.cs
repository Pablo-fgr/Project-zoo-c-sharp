using PAV_TPFinal_56340_Dominio.Entidades;

namespace PAV_TPFinal_56340_Infraestructura_Datos.Datos;

public class Iniciales
{
    private static Iniciales? _instance = null;
    private static readonly object _lock = new();

    private Iniciales()
    {
        Inicializar();
    }

    public static Iniciales Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new Iniciales();
                }
            }
            return _instance;
        }
    }

    public List<Pais> Paises { get; } = new List<Pais>();
    public List<Sector> Sectores { get; } = new List<Sector>();
    public List<Especie> Especies { get; } = new List<Especie>();
    public List<Animal> Animales { get; } = new List<Animal>();
    public List<Empleado> Empleados { get; } = [];

    private void Inicializar()
    {
        InicializarEspecies();
        InicializarPaises();
        InicializarSectores();
    }

    private void InicializarEspecies()
    {
        Especies.AddRange(
        [
            new Especie
            {
                Id = Guid.NewGuid(),
                Codigo = 1,
                Nombre = "León",
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                PorcentajePesoCarne = 0.7
            },
            new Especie
            {
                Id = Guid.NewGuid(),
                Codigo = 2,
                Nombre = "Jirafa",
                TipoAlimentacion = TipoAlimentacion.HERBIVORO
            },
            new Especie
            {
                Id = Guid.NewGuid(),
                Codigo = 3,
                Nombre = "Tigre",
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                PorcentajePesoCarne = 0.5
            },
            new Especie
            {
                Id = Guid.NewGuid(),
                Codigo = 4,
                Nombre = "Rinoceronte",
                TipoAlimentacion = TipoAlimentacion.HERBIVORO
            }
        ]);
    }

    private void InicializarPaises()
    {
        Paises.AddRange(
        [
            new Pais
            {
                Id = Guid.NewGuid(),
                Codigo = 1,
                Nombre = "Australia"
            },
            new Pais
            {
                Id = Guid.NewGuid(),
                Codigo = 2,
                Nombre = "Canadá"
            },
            new Pais
            {
                Id = Guid.NewGuid(),
                Codigo = 3,
                Nombre = "Singapur"
            },
            new Pais
            {
                Id = Guid.NewGuid(),
                Codigo = 4,
                Nombre = "Sudáfrica"
            }
        ]);
    }

    private void InicializarSectores()
    {
        var empleado1 = new Empleado
        {
            Id = Guid.NewGuid(),
            Nombre = "Luis",
            Dni = "12345678",
            Domicilio = "Tucumán"
        };
        var empleado2 = new Empleado
        {
            Id = Guid.NewGuid(),
            Nombre = "María",
            Dni = "87654321",
            Domicilio = "Tucumán"
        };
        Empleados.Add(empleado1);
        Empleados.Add(empleado2);
        Sectores.AddRange(
        [
            new Sector
            {
                Id = Guid.NewGuid(),
                Numero = 1,
                Latitud =-26.250724,
                Longitud = -65.522827,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.HERBIVORO,
                EmpleadoId = empleado1.Id
            },
            new Sector
            {
                Id = Guid.NewGuid(),
                Numero = 2,
                Latitud =-26.252359,
                Longitud = -65.521511,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                EmpleadoId = empleado1.Id
            },
            new Sector
            {
                Id = Guid.NewGuid(),
                Numero = 3,
                Latitud =-26.254661,
                Longitud = -65.522726,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.HERBIVORO,
                EmpleadoId = empleado2.Id
            },
            new Sector
            {
                Id = Guid.NewGuid(),
                Numero = 4,
                Latitud =-26.257250,
                Longitud = -65.523514,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                EmpleadoId = empleado2.Id
            }
        ]);
    }
}
