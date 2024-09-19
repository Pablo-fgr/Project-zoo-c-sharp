using PAV_TPFinal_56340_Presentacion.Interfaces;

namespace PAV_TPFinal_56340_Presentacion.Vistas
{
    partial class SectorView : SectorViewWithPresenter, ISectorView
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNumero = new Label();
            lblResponsable = new Label();
            dgAnimales = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pesoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            animalViewModelBindingSource = new BindingSource(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAnimales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)animalViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            tableLayoutPanel1.SetColumnSpan(webView21, 2);
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 53);
            webView21.Name = "webView21";
            webView21.Size = new Size(778, 274);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(webView21, 0, 1);
            tableLayoutPanel1.Controls.Add(lblNumero, 0, 0);
            tableLayoutPanel1.Controls.Add(lblResponsable, 1, 0);
            tableLayoutPanel1.Controls.Add(dgAnimales, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(784, 451);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.FromArgb(38, 38, 38);
            lblNumero.Dock = DockStyle.Fill;
            lblNumero.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(3, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(44, 50);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "1";
            lblNumero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.BackColor = Color.MidnightBlue;
            lblResponsable.Dock = DockStyle.Fill;
            lblResponsable.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsable.ForeColor = Color.White;
            lblResponsable.Location = new Point(53, 0);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(728, 50);
            lblResponsable.TabIndex = 2;
            lblResponsable.Text = "Nombre";
            lblResponsable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgAnimales
            // 
            dgAnimales.AllowUserToAddRows = false;
            dgAnimales.AllowUserToDeleteRows = false;
            dgAnimales.AutoGenerateColumns = false;
            dgAnimales.BackgroundColor = Color.FromArgb(38, 38, 38);
            dgAnimales.BorderStyle = BorderStyle.None;
            dgAnimales.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgAnimales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgAnimales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgAnimales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAnimales.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, edadDataGridViewTextBoxColumn, pesoDataGridViewTextBoxColumn, especieDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn });
            dgAnimales.DataSource = animalViewModelBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgAnimales.DefaultCellStyle = dataGridViewCellStyle4;
            dgAnimales.Dock = DockStyle.Fill;
            dgAnimales.GridColor = Color.White;
            dgAnimales.Location = new Point(53, 333);
            dgAnimales.Name = "dgAnimales";
            dgAnimales.ReadOnly = true;
            dgAnimales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgAnimales.RowHeadersVisible = false;
            dgAnimales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAnimales.Size = new Size(728, 115);
            dgAnimales.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            edadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            edadDataGridViewTextBoxColumn.ReadOnly = true;
            edadDataGridViewTextBoxColumn.Width = 80;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pesoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            pesoDataGridViewTextBoxColumn.ReadOnly = true;
            pesoDataGridViewTextBoxColumn.Width = 80;
            // 
            // especieDataGridViewTextBoxColumn
            // 
            especieDataGridViewTextBoxColumn.DataPropertyName = "Especie";
            especieDataGridViewTextBoxColumn.HeaderText = "Especie";
            especieDataGridViewTextBoxColumn.Name = "especieDataGridViewTextBoxColumn";
            especieDataGridViewTextBoxColumn.ReadOnly = true;
            especieDataGridViewTextBoxColumn.Width = 150;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            paisDataGridViewTextBoxColumn.ReadOnly = true;
            paisDataGridViewTextBoxColumn.Width = 150;
            // 
            // animalViewModelBindingSource
            // 
            animalViewModelBindingSource.DataSource = typeof(Modelos.AnimalViewModel);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 38, 38);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 333);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 115);
            panel1.TabIndex = 4;
            // 
            // SectorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 451);
            Controls.Add(tableLayoutPanel1);
            Name = "SectorView";
            Text = "Sector";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAnimales).EndInit();
            ((System.ComponentModel.ISupportInitialize)animalViewModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNumero;
        private Label lblResponsable;
        private DataGridView dgAnimales;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private BindingSource animalViewModelBindingSource;
        private Panel panel1;
    }
}