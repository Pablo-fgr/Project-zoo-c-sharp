using PAV_TPFinal_56340_Dominio.Entidades;

namespace PAV_TPFinal_56340_Presentacion.Vistas.Controles;

public partial class SectorControl : UserControl
{
    public Guid SectorId { get; set; }
    public event EventHandler<Guid>? SectorClicked;
    public SectorControl()
    {
        InitializeComponent();
    }

    public void ActualizarControl(Sector s)
    {
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
        SectorClicked?.Invoke(this, SectorId);
    }
}
