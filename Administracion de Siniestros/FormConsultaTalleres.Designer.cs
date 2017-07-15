namespace Administracion_de_Siniestros
{
    partial class FormConsultaTalleres
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonListado = new System.Windows.Forms.Button();
            this.buttonTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(610, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(457, 526);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 1;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonListado
            // 
            this.buttonListado.Location = new System.Drawing.Point(334, 10);
            this.buttonListado.Name = "buttonListado";
            this.buttonListado.Size = new System.Drawing.Size(120, 23);
            this.buttonListado.TabIndex = 3;
            this.buttonListado.Text = "Ver Solo del Listado";
            this.buttonListado.UseVisualStyleBackColor = true;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Location = new System.Drawing.Point(457, 10);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(75, 23);
            this.buttonTodos.TabIndex = 4;
            this.buttonTodos.Text = "Ver Todos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            // 
            // FormConsultaTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTodos);
            this.Controls.Add(this.buttonListado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaTalleres";
            this.Text = "Consulta Talleres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonListado;
        private System.Windows.Forms.Button buttonTodos;
    }
}