using PAV_TPFinal_56340_Dominio.Entidades;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface IZoologicoView : IView
{
    event EventHandler AgregarAnimalClicked;
    //event EventHandler SectorControlClicked;
    public void CargarSectores(List<Sector> sectores);
    public void CargarComida(double kgsCarnivoro, double kgsHerbivoro, double kgsTotales);
    public void ActualizarSector(Guid idSector);
}
