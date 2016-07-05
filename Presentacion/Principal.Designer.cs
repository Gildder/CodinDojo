namespace Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstrMenu = new System.Windows.Forms.MenuStrip();
            this.mtsNumeros = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsVectores = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsConjuntos = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.mstrMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrMenu
            // 
            this.mstrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsNumeros,
            this.mtsVectores,
            this.mtsConjuntos});
            this.mstrMenu.Location = new System.Drawing.Point(0, 0);
            this.mstrMenu.Name = "mstrMenu";
            this.mstrMenu.Size = new System.Drawing.Size(287, 24);
            this.mstrMenu.TabIndex = 1;
            this.mstrMenu.Text = "menuStrip1";
            // 
            // mtsNumeros
            // 
            this.mtsNumeros.Name = "mtsNumeros";
            this.mtsNumeros.Size = new System.Drawing.Size(68, 20);
            this.mtsNumeros.Text = "Numeros";
            this.mtsNumeros.Click += new System.EventHandler(this.mtsNumeros_Click);
            // 
            // mtsVectores
            // 
            this.mtsVectores.Name = "mtsVectores";
            this.mtsVectores.Size = new System.Drawing.Size(64, 20);
            this.mtsVectores.Text = "Vectores";
            this.mtsVectores.Click += new System.EventHandler(this.mtsVectores_Click);
            // 
            // mtsConjuntos
            // 
            this.mtsConjuntos.Name = "mtsConjuntos";
            this.mtsConjuntos.Size = new System.Drawing.Size(74, 20);
            this.mtsConjuntos.Text = "Conjuntos";
            this.mtsConjuntos.Click += new System.EventHandler(this.mtsConjuntos_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 24);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(287, 238);
            this.panelContenedor.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.mstrMenu);
            this.MainMenuStrip = this.mstrMenu;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstrMenu.ResumeLayout(false);
            this.mstrMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrMenu;
        private System.Windows.Forms.ToolStripMenuItem mtsNumeros;
        private System.Windows.Forms.ToolStripMenuItem mtsVectores;
        private System.Windows.Forms.ToolStripMenuItem mtsConjuntos;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

