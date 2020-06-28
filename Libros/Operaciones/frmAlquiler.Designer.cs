namespace Libros.Operaciones
{
    partial class frmAlquiler
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.grdAlquiler = new System.Windows.Forms.DataGridView();
            this.codigoDeAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDelAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCopiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeCopiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspObtenerAlqClteResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet1 = new Libros.PrestamosDataSet1();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.usp_ObtenerAlqClteTableAdapter = new Libros.PrestamosDataSet1TableAdapters.usp_ObtenerAlqClteTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspObtenerAlqClteResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alquiler de Libros";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(79, 99);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libros Alquilados";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(180, 99);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(224, 21);
            this.cmbCliente.TabIndex = 3;
            // 
            // grdAlquiler
            // 
            this.grdAlquiler.AllowUserToAddRows = false;
            this.grdAlquiler.AllowUserToDeleteRows = false;
            this.grdAlquiler.AutoGenerateColumns = false;
            this.grdAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeAlquilerDataGridViewTextBoxColumn,
            this.fechaDelAlquilerDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn,
            this.idAlqDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idCopiaDataGridViewTextBoxColumn,
            this.idLibroDataGridViewTextBoxColumn,
            this.numeroDeCopiaDataGridViewTextBoxColumn});
            this.grdAlquiler.ContextMenuStrip = this.contextMenuStrip1;
            this.grdAlquiler.DataSource = this.uspObtenerAlqClteResultBindingSource;
            this.grdAlquiler.Location = new System.Drawing.Point(82, 160);
            this.grdAlquiler.Name = "grdAlquiler";
            this.grdAlquiler.ReadOnly = true;
            this.grdAlquiler.Size = new System.Drawing.Size(546, 150);
            this.grdAlquiler.TabIndex = 4;
            // 
            // codigoDeAlquilerDataGridViewTextBoxColumn
            // 
            this.codigoDeAlquilerDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeAlquiler";
            this.codigoDeAlquilerDataGridViewTextBoxColumn.HeaderText = "CodigoDeAlquiler";
            this.codigoDeAlquilerDataGridViewTextBoxColumn.Name = "codigoDeAlquilerDataGridViewTextBoxColumn";
            this.codigoDeAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDelAlquilerDataGridViewTextBoxColumn
            // 
            this.fechaDelAlquilerDataGridViewTextBoxColumn.DataPropertyName = "FechaDelAlquiler";
            this.fechaDelAlquilerDataGridViewTextBoxColumn.HeaderText = "FechaDelAlquiler";
            this.fechaDelAlquilerDataGridViewTextBoxColumn.Name = "fechaDelAlquilerDataGridViewTextBoxColumn";
            this.fechaDelAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEstimadaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaEstimadaDevolucion";
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaEstimadaDevolucion";
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.Name = "fechaEstimadaDevolucionDataGridViewTextBoxColumn";
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAlqDataGridViewTextBoxColumn
            // 
            this.idAlqDataGridViewTextBoxColumn.DataPropertyName = "idAlq";
            this.idAlqDataGridViewTextBoxColumn.HeaderText = "idAlq";
            this.idAlqDataGridViewTextBoxColumn.Name = "idAlqDataGridViewTextBoxColumn";
            this.idAlqDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlqDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCopiaDataGridViewTextBoxColumn
            // 
            this.idCopiaDataGridViewTextBoxColumn.DataPropertyName = "idCopia";
            this.idCopiaDataGridViewTextBoxColumn.HeaderText = "idCopia";
            this.idCopiaDataGridViewTextBoxColumn.Name = "idCopiaDataGridViewTextBoxColumn";
            this.idCopiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCopiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idLibroDataGridViewTextBoxColumn
            // 
            this.idLibroDataGridViewTextBoxColumn.DataPropertyName = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.HeaderText = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.Name = "idLibroDataGridViewTextBoxColumn";
            this.idLibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLibroDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDeCopiaDataGridViewTextBoxColumn
            // 
            this.numeroDeCopiaDataGridViewTextBoxColumn.DataPropertyName = "NumeroDeCopia";
            this.numeroDeCopiaDataGridViewTextBoxColumn.HeaderText = "NumeroDeCopia";
            this.numeroDeCopiaDataGridViewTextBoxColumn.Name = "numeroDeCopiaDataGridViewTextBoxColumn";
            this.numeroDeCopiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uspObtenerAlqClteResultBindingSource
            // 
            this.uspObtenerAlqClteResultBindingSource.DataSource = typeof(LibrosEDM.ModeloAplicacion.usp_ObtenerAlqClte_Result);
            // 
            // prestamosDataSet1
            // 
            this.prestamosDataSet1.DataSetName = "PrestamosDataSet1";
            this.prestamosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(480, 88);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 5;
            this.btnIr.Text = "Ir A";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(570, 88);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(480, 118);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(570, 118);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(133, 345);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(232, 344);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(340, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(453, 342);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar Libro";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(553, 342);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 13;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // usp_ObtenerAlqClteTableAdapter
            // 
            this.usp_ObtenerAlqClteTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 70);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 390);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.grdAlquiler);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmAlquiler";
            this.Text = "frmAlquiler";
            this.Load += new System.EventHandler(this.frmAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspObtenerAlqClteResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridView grdAlquiler;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTerminar;
        private PrestamosDataSet1 prestamosDataSet1;
        private PrestamosDataSet1TableAdapters.usp_ObtenerAlqClteTableAdapter usp_ObtenerAlqClteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDelAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstimadaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCopiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeCopiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uspObtenerAlqClteResultBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}