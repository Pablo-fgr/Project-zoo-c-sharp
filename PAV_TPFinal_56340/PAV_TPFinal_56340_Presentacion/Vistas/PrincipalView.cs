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
        //VerZoo();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }

    private void verZooToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //VerZoo();
    }
    private void VerZoo()
    {
        /*var zooView = new ZoologicoView();
        zooView.MdiParent = this;
        zooView.Show();*/
    }
}

public class PrincipalViewWithPresenter : ViewBase<PrincipalPresenter> { }
