using PAV_TPFinal_56340_Presentacion.Interfaces;

namespace PAV_TPFinal_56340_Presentacion
{
    partial class AgregarAnimalView : AgregarAnimalViewWithPresenter, IAgregarAnimalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNombre = new Label();
            lblEspecie = new Label();
            lblEdad = new Label();
            lblPais = new Label();
            lblPeso = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            cbEspecie = new ComboBox();
            bsEspecie = new BindingSource(components);
            txtPeso = new TextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            cbPais = new ComboBox();
            bsPais = new BindingSource(components);
            lblSectores = new Label();
            lbSectores = new ListBox();
            bsSector = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsEspecie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSector).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Khaki;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEspecie, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEdad, 3, 2);
            tableLayoutPanel1.Controls.Add(lblPais, 1, 4);
            tableLayoutPanel1.Controls.Add(lblPeso, 3, 4);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(txtEdad, 3, 3);
            tableLayoutPanel1.Controls.Add(cbEspecie, 1, 3);
            tableLayoutPanel1.Controls.Add(txtPeso, 3, 5);
            tableLayoutPanel1.Controls.Add(btnAgregar, 3, 7);
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 8);
            tableLayoutPanel1.Controls.Add(cbPais, 1, 5);
            tableLayoutPanel1.Controls.Add(lblSectores, 1, 6);
            tableLayoutPanel1.Controls.Add(lbSectores, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.777778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2222223F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Bottom;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNombre.Location = new Point(83, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(274, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Dock = DockStyle.Bottom;
            lblEspecie.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEspecie.Location = new Point(83, 118);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(274, 17);
            lblEspecie.TabIndex = 1;
            lblEspecie.Text = "Especie";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Dock = DockStyle.Bottom;
            lblEdad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEdad.Location = new Point(443, 118);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(274, 17);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Dock = DockStyle.Bottom;
            lblPais.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPais.Location = new Point(83, 208);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(274, 17);
            lblPais.TabIndex = 3;
            lblPais.Text = "Pais de Origen";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Dock = DockStyle.Bottom;
            lblPeso.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPeso.Location = new Point(443, 208);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(274, 17);
            lblPeso.TabIndex = 4;
            lblPeso.Text = "Peso";
            // 
            // txtNombre
            // 
            tableLayoutPanel1.SetColumnSpan(txtNombre, 3);
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Location = new Point(83, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(634, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Dock = DockStyle.Fill;
            txtEdad.Location = new Point(443, 138);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(274, 23);
            txtEdad.TabIndex = 6;
            // 
            // cbEspecie
            // 
            cbEspecie.DataSource = bsEspecie;
            cbEspecie.DisplayMember = "Nombre";
            cbEspecie.Dock = DockStyle.Fill;
            cbEspecie.FormattingEnabled = true;
            cbEspecie.Location = new Point(83, 138);
            cbEspecie.Name = "cbEspecie";
            cbEspecie.Size = new Size(274, 23);
            cbEspecie.TabIndex = 7;
            cbEspecie.ValueMember = "Id";
            cbEspecie.SelectedIndexChanged += cbEspecie_SelectedIndexChanged;
            // 
            // bsEspecie
            // 
            bsEspecie.DataSource = typeof(PAV_TPFinal_56340_Dominio.Entidades.Especie);
            // 
            // txtPeso
            // 
            txtPeso.Dock = DockStyle.Fill;
            txtPeso.Location = new Point(443, 228);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(274, 23);
            txtPeso.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(443, 318);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(274, 38);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(443, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(274, 40);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cbPais
            // 
            cbPais.DataSource = bsPais;
            cbPais.DisplayMember = "Nombre";
            cbPais.Dock = DockStyle.Fill;
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(83, 228);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(274, 23);
            cbPais.TabIndex = 13;
            cbPais.ValueMember = "Id";
            // 
            // bsPais
            // 
            bsPais.DataSource = typeof(PAV_TPFinal_56340_Dominio.Entidades.Pais);
            // 
            // lblSectores
            // 
            lblSectores.AutoSize = true;
            lblSectores.Dock = DockStyle.Bottom;
            lblSectores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSectores.Location = new Point(83, 298);
            lblSectores.Name = "lblSectores";
            lblSectores.Size = new Size(274, 17);
            lblSectores.TabIndex = 14;
            lblSectores.Text = "Sector";
            // 
            // lbSectores
            // 
            lbSectores.DataSource = bsSector;
            lbSectores.DisplayMember = "Numero";
            lbSectores.Dock = DockStyle.Fill;
            lbSectores.FormattingEnabled = true;
            lbSectores.ItemHeight = 15;
            lbSectores.Location = new Point(83, 318);
            lbSectores.Name = "lbSectores";
            tableLayoutPanel1.SetRowSpan(lbSectores, 2);
            lbSectores.Size = new Size(274, 84);
            lbSectores.TabIndex = 15;
            lbSectores.ValueMember = "Id";
            // 
            // bsSector
            // 
            bsSector.DataSource = typeof(PAV_TPFinal_56340_Dominio.Entidades.Sector);
            // 
            // AgregarAnimalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "AgregarAnimalView";
            Text = "Agregar Animal";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsEspecie).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPais).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNombre;
        private Label lblEspecie;
        private Label lblEdad;
        private Label lblPais;
        private Label lblPeso;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private ComboBox cbEspecie;
        private TextBox txtPeso;
        private Button btnAgregar;
        private Button btnCancelar;
        private ComboBox cbPais;
        private Label lblSectores;
        private BindingSource bsEspecie;
        private BindingSource bsPais;
        private ListBox lbSectores;
        private BindingSource bsSector;
    }
}
