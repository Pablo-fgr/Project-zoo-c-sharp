using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Presentacion.Vistas.Controles;
using PAV_TPFinal_56340_Presentacion.Presentadores;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Infraestructura_Transversal;

namespace PAV_TPFinal_56340_Presentacion.Vistas;


public partial class ZoologicoView : ZoologicoViewWithPresenter, IZoologicoView
{
    private List<Sector>? sectores;

    public event EventHandler AgregarAnimalClicked
    {
        add { btnAgregarAnimal.Click += value; }
        remove { btnAgregarAnimal.Click -= value; }
    }
    public ZoologicoView()
    {
        InitializeComponent();
    }
    private void btnAgregarAnimal_Click(object sender, EventArgs e)
    {
    }
    private void btnCalcularComida_Click(object sender, EventArgs e)
    {
        Presentador!.CalcularKgsComida(sectores!);
    }

    public void CargarSectores(List<Sector> sectores)
    {
        foreach (Sector s in sectores)
        {
            var control = new SectorControl();
            control.ActualizarControl(s);
            control.SectorClicked += Presentador!.MostrarInfoSector;
            flpSectores.Controls.Add(control);
        }
    }

    public void CargarComida(double kgsCarnivoro, double kgsHerbivoro, double kgsTotales)
    {
        lblKgsCarnivoros.Text = string.Join(" ", kgsCarnivoro.ToString(), "kgs");
        lblKgsHerbivoros.Text = string.Join(" ", kgsHerbivoro.ToString(), "kgs");
        lblKgsTotal.Text = string.Join(" ", kgsTotales.ToString(), "kgs");
    }

    public void ActualizarSector(Guid idSector)
    {
        var s = Presentador!.ObtenerSector(idSector);
        if (s == null) return;
        SectorControl? control = flpSectores.Controls[s.Numero - 1] as SectorControl;
        control?.ActualizarControl(s);
    }

}

public class ZoologicoViewWithPresenter : ViewBase<ZoologicoPresenter> { }
