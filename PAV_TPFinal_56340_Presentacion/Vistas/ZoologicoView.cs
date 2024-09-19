using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Presentacion.Vistas.Controles;
using PAV_TPFinal_56340_Presentacion.Presentadores;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Infraestructura_Transversal;

namespace PAV_TPFinal_56340_Presentacion.Vistas;

public partial class ZoologicoView : ZoologicoViewWithPresenter, IZoologicoView
{
    public event EventHandler AgregarAnimalClicked
    {
        add { btnAgregarAnimal.Click += value; }
        remove { btnAgregarAnimal.Click -= value; }
    }

    public event EventHandler CalcComidaClicked
    {
        add { btnCalcularComida.Click += value; }
        remove { btnCalcularComida.Click -= value; }
    }
    public ZoologicoView()
    {
        InitializeComponent();
    }

    public void CargarSectores(List<Sector> sectores)
    {
        flpSectores.Controls.Clear();

        foreach (Sector s in sectores)
        {
            var control = new SectorControl();
            if (control == null) continue;
            control.SectorId = s.Id;
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
}

public class ZoologicoViewWithPresenter : ViewBase<ZoologicoPresenter> { }
