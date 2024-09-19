using PAV_TPFinal_56340_Dominio.Entidades;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface ISectorView : IView
{
    void RellenarInfoSector(Sector s);
    void ShowMap(Sector s);
}
