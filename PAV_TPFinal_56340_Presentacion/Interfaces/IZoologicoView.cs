using PAV_TPFinal_56340_Dominio.Entidades;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface IZoologicoView : IView
{
    event EventHandler AgregarAnimalClicked;
    event EventHandler CalcComidaClicked;
    void CargarSectores(List<Sector> sectores);
    void CargarComida(double kgsCarnivoro, double kgsHerbivoro, double kgsTotales);
}
