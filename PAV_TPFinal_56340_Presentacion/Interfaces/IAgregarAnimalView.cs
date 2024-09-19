using PAV_TPFinal_56340_Dominio.Entidades;

namespace PAV_TPFinal_56340_Presentacion.Interfaces;

public interface IAgregarAnimalView : IView
{
    event EventHandler AgregarClicked;
    event EventHandler CancelarClicked;
    void CargarEspecies(List<Especie> especies);
    void CargarPaises(List<Pais> paises);
    void CargarSectores(List<Sector> sectores, int tipoAnimal);
    void LimpiarCampos();
    void ValidarCampos();
}
