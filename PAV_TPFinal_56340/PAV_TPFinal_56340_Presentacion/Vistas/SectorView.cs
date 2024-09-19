using System.Data;
using System.Globalization;
using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;
using PAV_TPFinal_56340_Presentacion.Vistas;
using PAV_TPFinal_56340_Presentacion.Vistas.Modelos;

namespace PAV_TPFinal_56340_Presentacion.Vistas;

public partial class SectorView : SectorViewWithPresenter, ISectorView
{
    public SectorView()
    {
        InitializeComponent();
        //var idSector = Presentador!.Tarea!.SectorId;
        //var s = Presentador.ObtenerSector(idSector);
        //RellenarInfoSector(s);
    }

    public void RellenarInfoSector(Sector s)
    {
        lblNumero.Text = s.Numero.ToString();
        lblResponsable.Text = s.Empleado?.Nombre;
        animalViewModelBindingSource.DataSource = s.Animales.Select(a => new AnimalViewModel
        {
            Id = a.Codigo,
            Nombre = a.Nombre,
            Edad = a.Edad,
            Especie = a.Especie.Nombre,
            Pais = a.PaisOrigen.Nombre,
            Peso = a.Peso
        }).ToList();
        ShowMap(s);
    }

    public void ShowMap(Sector s)
    {
        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ".";
        webView21.Source = new Uri($"https://www.google.com/maps/search/?api=1&query={s.Latitud.ToString(nfi)}%2C{s.Longitud.ToString(nfi)}");
    }
}

public class SectorViewWithPresenter : ViewBase<SectorPresenter> { }
