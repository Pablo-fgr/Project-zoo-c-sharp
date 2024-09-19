using PAV_TPFinal_56340_Infraestructura_Transversal;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;
using PAV_TPFinal_56340_Presentacion.Vistas;

namespace PAV_TPFinal_56340_Presentacion.Vistas;

public partial class PrincipalView : PrincipalViewWithPresenter, IPrincipalView
{
    public event EventHandler VerZooClicked
    {
        add { verZooToolStripMenuItem.Click += value; }
        remove { verZooToolStripMenuItem.Click -= value;}
    }

    public event EventHandler AgregarAnimalClicked
    {
        add { agregarAnimalToolStripMenuItem.Click += value; }
        remove { agregarAnimalToolStripMenuItem.Click -= value; }
    }
    public PrincipalView()
    {
        InitializeComponent();
    }
}

public class PrincipalViewWithPresenter : ViewBase<PrincipalPresenter> { }
