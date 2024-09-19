using PAV_TPFinal_56340_Presentacion.Interfaces;

namespace PAV_TPFinal_56340_Presentacion.Vistas.Controles
{
    partial class SectorControl : SectorControlWithPresenter
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSector = new Label();
            lblEspecies = new Label();
            lblCantAnim = new Label();
            lblEmpleado = new Label();
            lblUbicacion = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblSector, 0, 0);
            tableLayoutPanel1.Controls.Add(lblEspecies, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCantAnim, 0, 2);
            tableLayoutPanel1.Controls.Add(lblEmpleado, 0, 3);
            tableLayoutPanel1.Controls.Add(lblUbicacion, 0, 4);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(194, 226);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Dock = DockStyle.Fill;
            lblSector.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSector.Location = new Point(5, 2);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(184, 42);
            lblSector.TabIndex = 0;
            lblSector.Text = "Sector";
            lblSector.TextAlign = ContentAlignment.MiddleCenter;
            lblSector.Click += SectorControl_Click;
            // 
            // lblEspecies
            // 
            lblEspecies.AutoSize = true;
            lblEspecies.Dock = DockStyle.Fill;
            lblEspecies.Location = new Point(5, 46);
            lblEspecies.Name = "lblEspecies";
            lblEspecies.Size = new Size(184, 42);
            lblEspecies.TabIndex = 1;
            lblEspecies.Text = "Especies";
            lblEspecies.TextAlign = ContentAlignment.MiddleCenter;
            lblEspecies.Click += SectorControl_Click;
            // 
            // lblCantAnim
            // 
            lblCantAnim.AutoSize = true;
            lblCantAnim.Dock = DockStyle.Fill;
            lblCantAnim.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantAnim.ForeColor = Color.DarkBlue;
            lblCantAnim.Location = new Point(5, 90);
            lblCantAnim.Name = "lblCantAnim";
            lblCantAnim.Size = new Size(184, 42);
            lblCantAnim.TabIndex = 2;
            lblCantAnim.Text = "Cant animales";
            lblCantAnim.TextAlign = ContentAlignment.MiddleCenter;
            lblCantAnim.Click += SectorControl_Click;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Dock = DockStyle.Fill;
            lblEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleado.Location = new Point(5, 134);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(184, 42);
            lblEmpleado.TabIndex = 3;
            lblEmpleado.Text = "Empleado";
            lblEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            lblEmpleado.Click += SectorControl_Click;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Dock = DockStyle.Fill;
            lblUbicacion.Location = new Point(5, 178);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(184, 46);
            lblUbicacion.TabIndex = 4;
            lblUbicacion.Text = "Ubicacion";
            lblUbicacion.TextAlign = ContentAlignment.MiddleCenter;
            lblUbicacion.Click += SectorControl_Click;
            // 
            // SectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(tableLayoutPanel1);
            Name = "SectorControl";
            Size = new Size(194, 226);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSector;
        private Label lblEspecies;
        private Label lblCantAnim;
        private Label lblEmpleado;
        private Label lblUbicacion;
    }
}
