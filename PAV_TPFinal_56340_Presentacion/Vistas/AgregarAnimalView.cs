using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;
using PAV_TPFinal_56340_Presentacion.Vistas;
using PAV_TPFinal_56340_Presentacion.Enums;
using System.Text.RegularExpressions;

namespace PAV_TPFinal_56340_Presentacion;

public partial class AgregarAnimalView : AgregarAnimalViewWithPresenter, IAgregarAnimalView
{
    public event EventHandler AgregarClicked
    {
        add { btnAgregar.Click += value; }
        remove { btnAgregar.Click -= value; }
    }

    public event EventHandler CancelarClicked
    {
        add { btnCancelar.Click += value; }
        remove { btnCancelar.Click -= value; }
    }
    public AgregarAnimalView()
    {
        InitializeComponent();
    }

    public void CargarEspecies(List<Especie> especies)
    {
        bsEspecie.DataSource = especies;
    }
    public void CargarPaises(List<Pais> paises)
    {
        bsPais.DataSource = paises;
    }
    public void CargarSectores(List<Sector> sectores, int tipoAnimal)
    {
        switch (tipoAnimal)
        {
            case 0:
                bsSector.DataSource = sectores;
                break;
            case 1:
                bsSector.DataSource = sectores
                    .Where(s => s.TipoAlimentacion == TipoAlimentacion.CARNIVORO);
                break;
            case 2:
                bsSector.DataSource = sectores
                    .Where(s => s.TipoAlimentacion == TipoAlimentacion.HERBIVORO);
                break;
            default:
                bsSector.DataSource = sectores;
                break;
        }
    }

    private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbEspecie.SelectedItem == null || cbEspecie.SelectedValue == null) return;

        if (!Guid.TryParse(cbEspecie.SelectedValue.ToString(), out Guid idEspecie)) return;

        if (idEspecie.Equals("")) return;

        Especie especie = Presentador!.ObtenerEspecie(idEspecie)!;
        List<Sector> sectores = Presentador!.ObtenerSectores();

        if (especie.TipoAlimentacion == TipoAlimentacion.CARNIVORO)
            CargarSectores(sectores, 1);
        else if (especie.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
            CargarSectores(sectores, 2);
    }
    public void LimpiarCampos()
    {
        txtNombre.Text = "";
        txtEdad.Text = "";
        txtPeso.Text = "";
        cbEspecie.SelectedIndex = 0;
        cbPais.SelectedIndex = 0;
        lbSectores.SelectedIndex = 0;
    }

    public void ValidarCampos()
    {
        string nombre = txtNombre.Text.Trim();

        if (!Guid.TryParse(cbEspecie.SelectedValue!.ToString(), out Guid idEspecie))
            MostrarMensaje("Debes seleccionar una especie!", Mensaje.ERROR);
        else if (!Guid.TryParse(cbPais.SelectedValue!.ToString(), out Guid idPais))
            MostrarMensaje("Debes seleccionar un pais!", Mensaje.ERROR);
        else if (!Guid.TryParse(lbSectores.SelectedValue!.ToString(),out Guid idSector))
            MostrarMensaje("Debes seleccionar un sector!", Mensaje.ERROR);
        else if (nombre.Equals(""))
            MostrarMensaje("El campo Nombre está vacío >:(", Mensaje.ERROR);
        else if (Regex.IsMatch(nombre, @"[^a-zA-Z]"))
            MostrarMensaje("El campo Nombre tiene un formato inválido", Mensaje.ERROR);
        else if (!int.TryParse(txtEdad.Text.Trim(), out int edad))
            MostrarMensaje("El campo Edad tiene un formato inválido", Mensaje.ERROR);
        else if (!double.TryParse(txtPeso.Text.Trim(), out double peso))
            MostrarMensaje("El campo Peso tiene un formato inválido", Mensaje.ERROR);
        else
        {
            Presentador!.AgregarAnimal(nombre, edad, peso, idEspecie, idPais, idSector);
            LimpiarCampos();
        }
    }
}

public class AgregarAnimalViewWithPresenter : ViewBase<AgregarAnimalPresenter> { }
