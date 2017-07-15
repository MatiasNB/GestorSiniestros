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
            this.aseguradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuInicio.SuspendLayout();
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
            this.menuInicio.Size = new System.Drawing.Size(284, 24);
            this.menuInicio.TabIndex = 0;
            this.menuInicio.Text = "menuInicio";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aseguradoToolStripMenuItem,
            this.siniestroToolStripMenuItem,
            this.inspeccionToolStripMenuItem,
            this.reclamoToolStripMenuItem,
            this.reintegroToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // aseguradoToolStripMenuItem
            // 
            this.aseguradoToolStripMenuItem.Name = "aseguradoToolStripMenuItem";
            this.aseguradoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aseguradoToolStripMenuItem.Text = "Asegurado";
            // 
            // siniestroToolStripMenuItem
            // 
            this.siniestroToolStripMenuItem.Name = "siniestroToolStripMenuItem";
            this.siniestroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.siniestroToolStripMenuItem.Text = "Siniestro";
            this.siniestroToolStripMenuItem.Click += new System.EventHandler(this.siniestroNuevo_Click);
            // 
            // inspeccionToolStripMenuItem
            // 
            this.inspeccionToolStripMenuItem.Name = "inspeccionToolStripMenuItem";
            this.inspeccionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inspeccionToolStripMenuItem.Text = "Inspeccion";
            // 
            // reclamoToolStripMenuItem
            // 
            this.reclamoToolStripMenuItem.Name = "reclamoToolStripMenuItem";
            this.reclamoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reclamoToolStripMenuItem.Text = "Reclamo";
            // 
            // reintegroToolStripMenuItem
            // 
            this.reintegroToolStripMenuItem.Name = "reintegroToolStripMenuItem";
            this.reintegroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuInicio);
            this.MainMenuStrip = this.menuInicio;
            this.Name = "Inicio";
            this.Text = "Administracion de Siniestros - Provincia Seguros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInicio;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aseguradoToolStripMenuItem;
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
    }
}

