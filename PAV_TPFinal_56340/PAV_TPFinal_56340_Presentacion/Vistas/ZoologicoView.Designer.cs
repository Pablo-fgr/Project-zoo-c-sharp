using PAV_TPFinal_56340_Presentacion.Interfaces;

namespace PAV_TPFinal_56340_Presentacion.Vistas
{
    partial class ZoologicoView : ZoologicoViewWithPresenter, IZoologicoView
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAgregarAnimal = new Button();
            btnCalcularComida = new Button();
            lblCarnivoros = new Label();
            lblKgsCarnivoros = new Label();
            lblHerbivoros = new Label();
            lblKgsHerbivoros = new Label();
            lblTotal = new Label();
            lblKgsTotal = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flpSectores = new FlowLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnAgregarAnimal, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCalcularComida, 0, 2);
            tableLayoutPanel2.Controls.Add(lblCarnivoros, 0, 4);
            tableLayoutPanel2.Controls.Add(lblKgsCarnivoros, 0, 5);
            tableLayoutPanel2.Controls.Add(lblHerbivoros, 0, 7);
            tableLayoutPanel2.Controls.Add(lblKgsHerbivoros, 0, 8);
            tableLayoutPanel2.Controls.Add(lblTotal, 0, 10);
            tableLayoutPanel2.Controls.Add(lblKgsTotal, 0, 11);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(583, 14);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel2.Size = new Size(194, 421);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnAgregarAnimal
            // 
            btnAgregarAnimal.BackColor = Color.LightSteelBlue;
            btnAgregarAnimal.Cursor = Cursors.Hand;
            btnAgregarAnimal.Dock = DockStyle.Fill;
            btnAgregarAnimal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAgregarAnimal.Location = new Point(3, 3);
            btnAgregarAnimal.Name = "btnAgregarAnimal";
            btnAgregarAnimal.Size = new Size(188, 36);
            btnAgregarAnimal.TabIndex = 0;
            btnAgregarAnimal.Text = "Agregar Animal";
            btnAgregarAnimal.UseVisualStyleBackColor = false;
            btnAgregarAnimal.Click += btnAgregarAnimal_Click;
            // 
            // btnCalcularComida
            // 
            btnCalcularComida.BackColor = Color.LightSalmon;
            btnCalcularComida.Cursor = Cursors.Hand;
            btnCalcularComida.Dock = DockStyle.Fill;
            btnCalcularComida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCalcularComida.Location = new Point(3, 55);
            btnCalcularComida.Name = "btnCalcularComida";
            btnCalcularComida.Size = new Size(188, 36);
            btnCalcularComida.TabIndex = 1;
            btnCalcularComida.Text = "Calcular Comida";
            btnCalcularComida.UseVisualStyleBackColor = false;
            btnCalcularComida.Click += btnCalcularComida_Click;
            // 
            // lblCarnivoros
            // 
            lblCarnivoros.AutoSize = true;
            lblCarnivoros.BackColor = Color.Wheat;
            lblCarnivoros.BorderStyle = BorderStyle.Fixed3D;
            lblCarnivoros.Dock = DockStyle.Fill;
            lblCarnivoros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblCarnivoros.Location = new Point(3, 136);
            lblCarnivoros.Name = "lblCarnivoros";
            lblCarnivoros.Size = new Size(188, 42);
            lblCarnivoros.TabIndex = 2;
            lblCarnivoros.Text = "Kgs Carnívoros";
            lblCarnivoros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgsCarnivoros
            // 
            lblKgsCarnivoros.AutoSize = true;
            lblKgsCarnivoros.BackColor = Color.White;
            lblKgsCarnivoros.BorderStyle = BorderStyle.Fixed3D;
            lblKgsCarnivoros.Dock = DockStyle.Fill;
            lblKgsCarnivoros.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblKgsCarnivoros.Location = new Point(3, 178);
            lblKgsCarnivoros.Name = "lblKgsCarnivoros";
            lblKgsCarnivoros.Size = new Size(188, 42);
            lblKgsCarnivoros.TabIndex = 3;
            lblKgsCarnivoros.Text = "0";
            lblKgsCarnivoros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHerbivoros
            // 
            lblHerbivoros.AutoSize = true;
            lblHerbivoros.BackColor = Color.Wheat;
            lblHerbivoros.BorderStyle = BorderStyle.Fixed3D;
            lblHerbivoros.Dock = DockStyle.Fill;
            lblHerbivoros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblHerbivoros.Location = new Point(3, 230);
            lblHerbivoros.Name = "lblHerbivoros";
            lblHerbivoros.Size = new Size(188, 42);
            lblHerbivoros.TabIndex = 4;
            lblHerbivoros.Text = "Kgs Herbívoros";
            lblHerbivoros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgsHerbivoros
            // 
            lblKgsHerbivoros.AutoSize = true;
            lblKgsHerbivoros.BackColor = Color.White;
            lblKgsHerbivoros.BorderStyle = BorderStyle.Fixed3D;
            lblKgsHerbivoros.Dock = DockStyle.Fill;
            lblKgsHerbivoros.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblKgsHerbivoros.Location = new Point(3, 272);
            lblKgsHerbivoros.Name = "lblKgsHerbivoros";
            lblKgsHerbivoros.Size = new Size(188, 42);
            lblKgsHerbivoros.TabIndex = 5;
            lblKgsHerbivoros.Text = "0";
            lblKgsHerbivoros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Wheat;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTotal.Location = new Point(3, 324);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(188, 42);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Kgs Total";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgsTotal
            // 
            lblKgsTotal.AutoSize = true;
            lblKgsTotal.BackColor = Color.White;
            lblKgsTotal.BorderStyle = BorderStyle.Fixed3D;
            lblKgsTotal.Dock = DockStyle.Fill;
            lblKgsTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblKgsTotal.Location = new Point(3, 366);
            lblKgsTotal.Name = "lblKgsTotal";
            lblKgsTotal.Size = new Size(188, 42);
            lblKgsTotal.TabIndex = 7;
            lblKgsTotal.Text = "0";
            lblKgsTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Khaki;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 1);
            tableLayoutPanel1.Controls.Add(flpSectores, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flpSectores
            // 
            flpSectores.Dock = DockStyle.Fill;
            flpSectores.Location = new Point(23, 14);
            flpSectores.Name = "flpSectores";
            flpSectores.Size = new Size(534, 421);
            flpSectores.TabIndex = 5;
            // 
            // ZoologicoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ZoologicoView";
            Text = "Zoologico";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregarAnimal;
        private Button btnCalcularComida;
        private Label lblCarnivoros;
        private Label lblKgsCarnivoros;
        private Label lblHerbivoros;
        private Label lblKgsHerbivoros;
        private Label lblTotal;
        private Label lblKgsTotal;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpSectores;
    }
}