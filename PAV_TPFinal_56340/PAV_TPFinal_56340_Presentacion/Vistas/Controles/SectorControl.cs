using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Dominio.Repositorios;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;

namespace PAV_TPFinal_56340_Presentacion.Vistas.Controles;

public partial class SectorControl : SectorControlWithPresenter
{
    public event EventHandler<Guid> SectorClicked;
    public Guid IdSector { get; set; }
    public SectorControl(/*Guid idSector*//*Sector s*/)
    {
        InitializeComponent();
        //_idSector = idSector;
        //IdSector = s!.Id;
        //var s = Presentador!.ObtenerSector(idSector);
        //s!.Empleado = Presentador!.ObtenerEmpleadoSector(s.EmpleadoId);
        //s!.Animales = Presentador!.ObtenerAnimalesSector(s.Id);
        //s.Animales = _repositorio.Listar<Animal>(a => a.SectorId == s.Id);
        //s.Empleado = _repositorio.ObtenerElPrimero<Empleado>(e => e.Id == s.EmpleadoId);
        //ActualizarControl(s);
    }

    public void ActualizarControl(Sector s)
    {
        IdSector = s.Id;
        lblSector.Text = $"Sector {s.Numero}";
        lblEspecies.Text = s.DistinguirAnimales();
        lblCantAnim.Text = s.Animales.Count.ToString();
        lblEmpleado.Text = s.Empleado?.Nombre;
        lblUbicacion.Text = $"{s.Latitud} ; {s.Longitud}";

        if ((s.Animales.Count > 0) && (s.TipoAlimentacion == TipoAlimentacion.CARNIVORO))
            BackColor = Color.Yellow;
        else if ((s.Animales.Count > 0) && (s.TipoAlimentacion == TipoAlimentacion.HERBIVORO))
            BackColor = Color.LawnGreen;
        else
            BackColor = Color.Silver;
    }

    

    private void SectorControl_Click(object sender, EventArgs e)
    {
        //SectorSeleccionado?.Invoke(this,_sectorId);
        SectorClicked?.Invoke(this, IdSector);
    }
}

public class SectorControlWithPresenter : ControlBase<SectorPresenter> { }
