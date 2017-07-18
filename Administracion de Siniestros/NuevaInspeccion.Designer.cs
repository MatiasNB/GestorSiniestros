namespace Administracion_de_Siniestros
{
    partial class NuevaInspeccion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonGuardarCargar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSniestro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGuardarCargar);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 36);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Eduardo",
            "Diego",
            "Fernando",
            "Dario",
            "Maximiliano"});
            this.comboBox1.Location = new System.Drawing.Point(4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(132, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarCargar
            // 
            this.buttonGuardarCargar.Location = new System.Drawing.Point(214, 4);
            this.buttonGuardarCargar.Name = "buttonGuardarCargar";
            this.buttonGuardarCargar.Size = new System.Drawing.Size(102, 23);
            this.buttonGuardarCargar.TabIndex = 2;
            this.buttonGuardarCargar.Text = "Guardar Cargar";
            this.buttonGuardarCargar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.labelObservaciones);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.labelSniestro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 225);
            this.panel2.TabIndex = 1;
            // 
            // labelSniestro
            // 
            this.labelSniestro.AutoSize = true;
            this.labelSniestro.Location = new System.Drawing.Point(13, 7);
            this.labelSniestro.Name = "labelSniestro";
            this.labelSniestro.Size = new System.Drawing.Size(47, 13);
            this.labelSniestro.TabIndex = 0;
            this.labelSniestro.Text = "Siniestro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Location = new System.Drawing.Point(13, 27);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(78, 13);
            this.labelObservaciones.TabIndex = 2;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 170);
            this.textBox2.TabIndex = 3;
            // 
            // NuevaInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaInspeccion";
            this.Text = "NuevaInspeccion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonGuardarCargar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSniestro;
    }
}