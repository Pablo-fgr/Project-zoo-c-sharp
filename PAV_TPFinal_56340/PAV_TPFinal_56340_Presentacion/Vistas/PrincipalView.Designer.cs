using PAV_TPFinal_56340_Presentacion.Interfaces;

namespace PAV_TPFinal_56340_Presentacion.Vistas
{
    partial class PrincipalView : PrincipalViewWithPresenter, IPrincipalView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            agregarAnimalToolStripMenuItem = new ToolStripMenuItem();
            verZooToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarAnimalToolStripMenuItem, verZooToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(85, 24);
            toolStripMenuItem1.Text = "Opciones";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // agregarAnimalToolStripMenuItem
            // 
            agregarAnimalToolStripMenuItem.Name = "agregarAnimalToolStripMenuItem";
            agregarAnimalToolStripMenuItem.Size = new Size(224, 26);
            agregarAnimalToolStripMenuItem.Text = "Agregar Animal";
            // 
            // verZooToolStripMenuItem
            // 
            verZooToolStripMenuItem.Name = "verZooToolStripMenuItem";
            verZooToolStripMenuItem.Size = new Size(224, 26);
            verZooToolStripMenuItem.Text = "Ver Zoo";
            verZooToolStripMenuItem.Click += verZooToolStripMenuItem_Click;
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "PrincipalView";
            Text = "PrincipalView";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem agregarAnimalToolStripMenuItem;
        private ToolStripMenuItem verZooToolStripMenuItem;
    }
}