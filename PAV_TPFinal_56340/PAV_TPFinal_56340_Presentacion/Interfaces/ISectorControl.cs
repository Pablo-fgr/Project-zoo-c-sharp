using PAV_TPFinal_56340_Dominio.Entidades;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface ISectorControl : IControl
{
    public Guid IdSector { get; set; }
    event EventHandler SectorClicked;
    void ActualizarControl(Sector s);

}
