namespace Presentacion
{
    partial class Numeros
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
            if(disposing && (components != null))
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Factorial");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Primo");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Par");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Invertir");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Capicua");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Contar Digitos");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Contar Digitos Primos");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Contar Digitos Par Impar ");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Mostrar Digitos Primos ");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Promedio de Pares ");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Eliminar Primos ");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Eliminar Digitos Repetidos ");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ordenar de Mayor a Menor ");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Ordenar de Menor a Mayor ");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Convertir un Numero a Literal");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Salilr ");
            this.lblVectores = new System.Windows.Forms.Label();
            this.lblDimensionar = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.dgvVector = new System.Windows.Forms.DataGridView();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVectores
            // 
            this.lblVectores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVectores.AutoSize = true;
            this.lblVectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectores.Location = new System.Drawing.Point(313, 23);
            this.lblVectores.Name = "lblVectores";
            this.lblVectores.Size = new System.Drawing.Size(218, 24);
            this.lblVectores.TabIndex = 0;
            this.lblVectores.Text = "NUMEROS ENTEROS";
            this.lblVectores.Click += new System.EventHandler(this.lblVectores_Click);
            // 
            // lblDimensionar
            // 
            this.lblDimensionar.AutoSize = true;
            this.lblDimensionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensionar.Location = new System.Drawing.Point(26, 84);
            this.lblDimensionar.Name = "lblDimensionar";
            this.lblDimensionar.Size = new System.Drawing.Size(171, 17);
            this.lblDimensionar.TabIndex = 2;
            this.lblDimensionar.Text = "Introduzca un numero:";
            this.lblDimensionar.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(213, 84);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(305, 20);
            this.tbxNumero.TabIndex = 3;
            this.tbxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumero);
            // 
            // dgvVector
            // 
            this.dgvVector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVector.Location = new System.Drawing.Point(53, 130);
            this.dgvVector.Name = "dgvVector";
            this.dgvVector.Size = new System.Drawing.Size(506, 23);
            this.dgvVector.TabIndex = 7;
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            treeNode1.Name = "Factorial";
            treeNode1.Text = "Factorial";
            treeNode2.Name = "Primo";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            treeNode2.Text = "Primo";
            treeNode3.Name = "Par";
            treeNode3.Text = "Par";
            treeNode4.Name = "Invertir";
            treeNode4.Text = "Invertir";
            treeNode5.Name = "Capicua";
            treeNode5.Text = "Capicua";
            treeNode6.Name = "Contar Digitos";
            treeNode6.Text = "Contar Digitos";
            treeNode7.Name = "Contar Digitos Primos";
            treeNode7.Text = "Contar Digitos Primos";
            treeNode8.Name = "Contar Digitos Par Impar ";
            treeNode8.Text = "Contar Digitos Par Impar ";
            treeNode9.Name = "Mostrar Digitos Primos ";
            treeNode9.Text = "Mostrar Digitos Primos ";
            treeNode10.Name = "Promedio de Pares ";
            treeNode10.Text = "Promedio de Pares ";
            treeNode11.Name = "Eliminar Primos ";
            treeNode11.Text = "Eliminar Primos ";
            treeNode12.Name = "Eliminar Digitos Repetidos ";
            treeNode12.Text = "Eliminar Digitos Repetidos ";
            treeNode13.Name = "Ordenar de Mayor a Menor ";
            treeNode13.Text = "Ordenar de Mayor a Menor ";
            treeNode14.Name = "Ordenar de Menor a Mayor ";
            treeNode14.Text = "Ordenar de Menor a Mayor ";
            treeNode15.Name = "Convertir un Numero a Literal";
            treeNode15.Text = "Convertir un Numero a Literal";
            treeNode16.Name = "Operaciones ";
            treeNode16.Text = "Operaciones";
            treeNode17.Name = "Salir ";
            treeNode17.Text = "Salilr ";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.trvMenu.Size = new System.Drawing.Size(209, 430);
            this.trvMenu.TabIndex = 8;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbxNumero);
            this.panel1.Controls.Add(this.dgvVector);
            this.panel1.Controls.Add(this.lblDimensionar);
            this.panel1.Controls.Add(this.lblVectores);
            this.panel1.Location = new System.Drawing.Point(209, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 430);
            this.panel1.TabIndex = 9;
            // 
            // Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 430);
            this.Controls.Add(this.trvMenu);
            this.Controls.Add(this.panel1);
            this.Name = "Numeros";
            this.Text = "Numeros";
            this.Load += new System.EventHandler(this.Numeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVectores;
        private System.Windows.Forms.Label lblDimensionar;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.DataGridView dgvVector;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.Panel panel1;
    }
}