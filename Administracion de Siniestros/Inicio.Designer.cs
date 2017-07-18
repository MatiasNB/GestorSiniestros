namespace Administracion_de_Siniestros
{
    partial class Inicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuInicio = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siniestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talleresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vencimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tapInspecciones = new System.Windows.Forms.TabPage();
            this.dataGridViewInspecciones1 = new Administracion_de_Siniestros.DataGridViewInspecciones();
            this.panelOpcionesInspectores = new System.Windows.Forms.Panel();
            this.buttonReporteInspectores = new System.Windows.Forms.Button();
            this.buttonActivas = new System.Windows.Forms.Button();
            this.buttonActualiarInspecciones = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonNuevaInspeccion = new System.Windows.Forms.Button();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSiniestroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizarDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSiniestroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuInicio.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tapInspecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInspecciones1)).BeginInit();
            this.panelOpcionesInspectores.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInicio
            // 
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.vencimientosToolStripMenuItem});
            this.menuInicio.Location = new System.Drawing.Point(0, 0);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(474, 24);
            this.menuInicio.TabIndex = 0;
            this.menuInicio.Text = "menuInicio";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siniestroToolStripMenuItem,
            this.inspeccionToolStripMenuItem,
            this.reclamoToolStripMenuItem,
            this.reintegroToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // siniestroToolStripMenuItem
            // 
            this.siniestroToolStripMenuItem.Name = "siniestroToolStripMenuItem";
            this.siniestroToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.siniestroToolStripMenuItem.Text = "Siniestro";
            this.siniestroToolStripMenuItem.Click += new System.EventHandler(this.siniestroNuevo_Click);
            // 
            // inspeccionToolStripMenuItem
            // 
            this.inspeccionToolStripMenuItem.Name = "inspeccionToolStripMenuItem";
            this.inspeccionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.inspeccionToolStripMenuItem.Text = "Inspeccion";
            // 
            // reclamoToolStripMenuItem
            // 
            this.reclamoToolStripMenuItem.Name = "reclamoToolStripMenuItem";
            this.reclamoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.reclamoToolStripMenuItem.Text = "Reclamo";
            // 
            // reintegroToolStripMenuItem
            // 
            this.reintegroToolStripMenuItem.Name = "reintegroToolStripMenuItem";
            this.reintegroToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.reintegroToolStripMenuItem.Text = "Reintegro";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inspectoresToolStripMenuItem,
            this.talleresToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // inspectoresToolStripMenuItem
            // 
            this.inspectoresToolStripMenuItem.Name = "inspectoresToolStripMenuItem";
            this.inspectoresToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.inspectoresToolStripMenuItem.Text = "Inspectores";
            this.inspectoresToolStripMenuItem.Click += new System.EventHandler(this.inspectoresToolStripMenuItem_Click);
            // 
            // talleresToolStripMenuItem
            // 
            this.talleresToolStripMenuItem.Name = "talleresToolStripMenuItem";
            this.talleresToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.talleresToolStripMenuItem.Text = "Talleres";
            this.talleresToolStripMenuItem.Click += new System.EventHandler(this.talleresToolStripMenuItem_Click);
            // 
            // vencimientosToolStripMenuItem
            // 
            this.vencimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inspeccionesToolStripMenuItem,
            this.reclamosToolStripMenuItem,
            this.reintegrosToolStripMenuItem});
            this.vencimientosToolStripMenuItem.Name = "vencimientosToolStripMenuItem";
            this.vencimientosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.vencimientosToolStripMenuItem.Text = "Vencimientos";
            // 
            // inspeccionesToolStripMenuItem
            // 
            this.inspeccionesToolStripMenuItem.Name = "inspeccionesToolStripMenuItem";
            this.inspeccionesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.inspeccionesToolStripMenuItem.Text = "Inspecciones";
            // 
            // reclamosToolStripMenuItem
            // 
            this.reclamosToolStripMenuItem.Name = "reclamosToolStripMenuItem";
            this.reclamosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.reclamosToolStripMenuItem.Text = "Reclamos";
            // 
            // reintegrosToolStripMenuItem
            // 
            this.reintegrosToolStripMenuItem.Name = "reintegrosToolStripMenuItem";
            this.reintegrosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.reintegrosToolStripMenuItem.Text = "Reintegros";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tapInspecciones);
            this.tabControl.Controls.Add(this.tabPedidos);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(474, 237);
            this.tabControl.TabIndex = 1;
            // 
            // tapInspecciones
            // 
            this.tapInspecciones.Controls.Add(this.dataGridViewInspecciones1);
            this.tapInspecciones.Controls.Add(this.panelOpcionesInspectores);
            this.tapInspecciones.Location = new System.Drawing.Point(4, 22);
            this.tapInspecciones.Name = "tapInspecciones";
            this.tapInspecciones.Padding = new System.Windows.Forms.Padding(3);
            this.tapInspecciones.Size = new System.Drawing.Size(466, 211);
            this.tapInspecciones.TabIndex = 0;
            this.tapInspecciones.Text = "Inspecciones";
            this.tapInspecciones.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInspecciones1
            // 
            this.dataGridViewInspecciones1.AllowUserToAddRows = false;
            this.dataGridViewInspecciones1.AllowUserToDeleteRows = false;
            this.dataGridViewInspecciones1.AllowUserToOrderColumns = true;
            this.dataGridViewInspecciones1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInspecciones1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInspecciones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInspecciones1.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewInspecciones1.Name = "dataGridViewInspecciones1";
            this.dataGridViewInspecciones1.Size = new System.Drawing.Size(460, 170);
            this.dataGridViewInspecciones1.TabIndex = 1;
            this.dataGridViewInspecciones1.Sorted += new System.EventHandler(this.dataGridViewInspecciones1_Sorted);
            // 
            // panelOpcionesInspectores
            // 
            this.panelOpcionesInspectores.BackColor = System.Drawing.Color.DarkGray;
            this.panelOpcionesInspectores.Controls.Add(this.buttonReporteInspectores);
            this.panelOpcionesInspectores.Controls.Add(this.buttonActivas);
            this.panelOpcionesInspectores.Controls.Add(this.buttonActualiarInspecciones);
            this.panelOpcionesInspectores.Controls.Add(this.comboBox1);
            this.panelOpcionesInspectores.Controls.Add(this.buttonNuevaInspeccion);
            this.panelOpcionesInspectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcionesInspectores.Location = new System.Drawing.Point(3, 3);
            this.panelOpcionesInspectores.Name = "panelOpcionesInspectores";
            this.panelOpcionesInspectores.Size = new System.Drawing.Size(460, 35);
            this.panelOpcionesInspectores.TabIndex = 0;
            // 
            // buttonReporteInspectores
            // 
            this.buttonReporteInspectores.Enabled = false;
            this.buttonReporteInspectores.Location = new System.Drawing.Point(378, 5);
            this.buttonReporteInspectores.Name = "buttonReporteInspectores";
            this.buttonReporteInspectores.Size = new System.Drawing.Size(75, 23);
            this.buttonReporteInspectores.TabIndex = 4;
            this.buttonReporteInspectores.Text = "Reporte";
            this.buttonReporteInspectores.UseVisualStyleBackColor = true;
            // 
            // buttonActivas
            // 
            this.buttonActivas.Location = new System.Drawing.Point(297, 5);
            this.buttonActivas.Name = "buttonActivas";
            this.buttonActivas.Size = new System.Drawing.Size(75, 23);
            this.buttonActivas.TabIndex = 3;
            this.buttonActivas.Text = "Activas";
            this.buttonActivas.UseVisualStyleBackColor = true;
            this.buttonActivas.Click += new System.EventHandler(this.buttonActivas_Click);
            // 
            // buttonActualiarInspecciones
            // 
            this.buttonActualiarInspecciones.Location = new System.Drawing.Point(216, 5);
            this.buttonActualiarInspecciones.Name = "buttonActualiarInspecciones";
            this.buttonActualiarInspecciones.Size = new System.Drawing.Size(75, 23);
            this.buttonActualiarInspecciones.TabIndex = 2;
            this.buttonActualiarInspecciones.Text = "Actualizar";
            this.buttonActualiarInspecciones.UseVisualStyleBackColor = true;
            this.buttonActualiarInspecciones.Click += new System.EventHandler(this.buttonActualiarInspecciones_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todas",
            "Eduardo",
            "Diego",
            "Fernando",
            "Dario",
            "Maximiliano"});
            this.comboBox1.Location = new System.Drawing.Point(88, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonNuevaInspeccion
            // 
            this.buttonNuevaInspeccion.Location = new System.Drawing.Point(6, 4);
            this.buttonNuevaInspeccion.Name = "buttonNuevaInspeccion";
            this.buttonNuevaInspeccion.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevaInspeccion.TabIndex = 0;
            this.buttonNuevaInspeccion.Text = "Nueva";
            this.buttonNuevaInspeccion.UseVisualStyleBackColor = true;
            this.buttonNuevaInspeccion.Click += new System.EventHandler(this.buttonNuevaInspeccion_Click);
            // 
            // tabPedidos
            // 
            this.tabPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(466, 211);
            this.tabPedidos.TabIndex = 1;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // idSiniestroDataGridViewTextBoxColumn1
            // 
            this.idSiniestroDataGridViewTextBoxColumn1.DataPropertyName = "idSiniestro";
            this.idSiniestroDataGridViewTextBoxColumn1.HeaderText = "idSiniestro";
            this.idSiniestroDataGridViewTextBoxColumn1.Name = "idSiniestroDataGridViewTextBoxColumn1";
            // 
            // fechaIPDataGridViewTextBoxColumn1
            // 
            this.fechaIPDataGridViewTextBoxColumn1.DataPropertyName = "fechaIP";
            this.fechaIPDataGridViewTextBoxColumn1.HeaderText = "fechaIP";
            this.fechaIPDataGridViewTextBoxColumn1.Name = "fechaIPDataGridViewTextBoxColumn1";
            // 
            // demoraDataGridViewTextBoxColumn1
            // 
            this.demoraDataGridViewTextBoxColumn1.DataPropertyName = "demora";
            this.demoraDataGridViewTextBoxColumn1.HeaderText = "demora";
            this.demoraDataGridViewTextBoxColumn1.Name = "demoraDataGridViewTextBoxColumn1";
            // 
            // finalizarDataGridViewCheckBoxColumn1
            // 
            this.finalizarDataGridViewCheckBoxColumn1.DataPropertyName = "finalizar";
            this.finalizarDataGridViewCheckBoxColumn1.HeaderText = "finalizar";
            this.finalizarDataGridViewCheckBoxColumn1.Name = "finalizarDataGridViewCheckBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSiniestroDataGridViewTextBoxColumn
            // 
            this.idSiniestroDataGridViewTextBoxColumn.DataPropertyName = "idSiniestro";
            this.idSiniestroDataGridViewTextBoxColumn.HeaderText = "idSiniestro";
            this.idSiniestroDataGridViewTextBoxColumn.Name = "idSiniestroDataGridViewTextBoxColumn";
            this.idSiniestroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaIPDataGridViewTextBoxColumn
            // 
            this.fechaIPDataGridViewTextBoxColumn.DataPropertyName = "fechaIP";
            this.fechaIPDataGridViewTextBoxColumn.HeaderText = "fechaIP";
            this.fechaIPDataGridViewTextBoxColumn.Name = "fechaIPDataGridViewTextBoxColumn";
            this.fechaIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demoraDataGridViewTextBoxColumn
            // 
            this.demoraDataGridViewTextBoxColumn.DataPropertyName = "demora";
            this.demoraDataGridViewTextBoxColumn.HeaderText = "demora";
            this.demoraDataGridViewTextBoxColumn.Name = "demoraDataGridViewTextBoxColumn";
            this.demoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalizarDataGridViewCheckBoxColumn
            // 
            this.finalizarDataGridViewCheckBoxColumn.DataPropertyName = "finalizar";
            this.finalizarDataGridViewCheckBoxColumn.HeaderText = "finalizar";
            this.finalizarDataGridViewCheckBoxColumn.Name = "finalizarDataGridViewCheckBoxColumn";
            this.finalizarDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuInicio);
            this.MainMenuStrip = this.menuInicio;
            this.Name = "Inicio";
            this.Text = "Administracion de Siniestros - Provincia Seguros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tapInspecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInspecciones1)).EndInit();
            this.panelOpcionesInspectores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInicio;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siniestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talleresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vencimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegrosToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tapInspecciones;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSiniestroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalizarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSiniestroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalizarDataGridViewCheckBoxColumn1;
        private Inspecciones ips;
        private System.Windows.Forms.Panel panelOpcionesInspectores;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonNuevaInspeccion;
        private DataGridViewInspecciones dataGridViewInspecciones1;
        private System.Windows.Forms.Button buttonReporteInspectores;
        private System.Windows.Forms.Button buttonActivas;
        private System.Windows.Forms.Button buttonActualiarInspecciones;
    }
}

