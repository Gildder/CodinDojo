namespace Presentacion
{
    partial class Vectores
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Contar Capicuas");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Contar Primos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ordenar Vector");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Eliminar Capicuas");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Eliminar Repetidos");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Eliminar Primos");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Buscar Elemento");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Salir");
            this.lblVectores = new System.Windows.Forms.Label();
            this.btnDimensionar = new System.Windows.Forms.Button();
            this.lblDimensionar = new System.Windows.Forms.Label();
            this.tbxDimension = new System.Windows.Forms.TextBox();
            this.lblVector = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoValor = new System.Windows.Forms.Label();
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
            this.lblVectores.Size = new System.Drawing.Size(93, 24);
            this.lblVectores.TabIndex = 0;
            this.lblVectores.Text = "Vectores";
            // 
            // btnDimensionar
            // 
            this.btnDimensionar.Location = new System.Drawing.Point(360, 82);
            this.btnDimensionar.Name = "btnDimensionar";
            this.btnDimensionar.Size = new System.Drawing.Size(75, 23);
            this.btnDimensionar.TabIndex = 1;
            this.btnDimensionar.Text = "Dimensionar";
            this.btnDimensionar.UseVisualStyleBackColor = true;
            this.btnDimensionar.Click += new System.EventHandler(this.btnDimensionar_Click);
            // 
            // lblDimensionar
            // 
            this.lblDimensionar.AutoSize = true;
            this.lblDimensionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensionar.Location = new System.Drawing.Point(48, 82);
            this.lblDimensionar.Name = "lblDimensionar";
            this.lblDimensionar.Size = new System.Drawing.Size(200, 17);
            this.lblDimensionar.TabIndex = 2;
            this.lblDimensionar.Text = "Numero para dimensionar:";
            // 
            // tbxDimension
            // 
            this.tbxDimension.Location = new System.Drawing.Point(254, 81);
            this.tbxDimension.Name = "tbxDimension";
            this.tbxDimension.Size = new System.Drawing.Size(100, 20);
            this.tbxDimension.TabIndex = 3;
            this.tbxDimension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDimension_KeyPress);
            // 
            // lblVector
            // 
            this.lblVector.AutoSize = true;
            this.lblVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVector.Location = new System.Drawing.Point(257, 111);
            this.lblVector.Name = "lblVector";
            this.lblVector.Size = new System.Drawing.Size(74, 17);
            this.lblVector.TabIndex = 4;
            this.lblVector.Text = "Vector = ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(257, 210);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(121, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "RESULTADO = ";
            // 
            // lblResultadoValor
            // 
            this.lblResultadoValor.AutoSize = true;
            this.lblResultadoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoValor.Location = new System.Drawing.Point(384, 210);
            this.lblResultadoValor.Name = "lblResultadoValor";
            this.lblResultadoValor.Size = new System.Drawing.Size(17, 17);
            this.lblResultadoValor.TabIndex = 6;
            this.lblResultadoValor.Text = "#";
            // 
            // dgvVector
            // 
            this.dgvVector.AllowUserToAddRows = false;
            this.dgvVector.AllowUserToDeleteRows = false;
            this.dgvVector.AllowUserToResizeColumns = false;
            this.dgvVector.AllowUserToResizeRows = false;
            this.dgvVector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVector.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvVector.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVector.Location = new System.Drawing.Point(341, 111);
            this.dgvVector.Name = "dgvVector";
            this.dgvVector.ReadOnly = true;
            this.dgvVector.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvVector.Size = new System.Drawing.Size(506, 73);
            this.dgvVector.TabIndex = 7;
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            treeNode1.Name = "ContarCapicuas";
            treeNode1.Text = "Contar Capicuas";
            treeNode2.Name = "ContarPrimos";
            treeNode2.Text = "Contar Primos";
            treeNode3.Name = "OrdenarVector";
            treeNode3.Text = "Ordenar Vector";
            treeNode4.Name = "EliminarCapicuas";
            treeNode4.Text = "Eliminar Capicuas";
            treeNode5.Name = "EliminarRepetidos";
            treeNode5.Text = "Eliminar Repetidos";
            treeNode6.Name = "EliminarPrimos";
            treeNode6.Text = "Eliminar Primos";
            treeNode7.Name = "BuscarElemento";
            treeNode7.Text = "Buscar Elemento";
            treeNode8.Name = "Operaciones";
            treeNode8.Text = "Operaciones";
            treeNode9.Name = "Salir";
            treeNode9.Text = "Salir";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            this.trvMenu.Size = new System.Drawing.Size(209, 430);
            this.trvMenu.TabIndex = 8;
            this.trvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMenu_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDimensionar);
            this.panel1.Controls.Add(this.tbxDimension);
            this.panel1.Controls.Add(this.lblDimensionar);
            this.panel1.Controls.Add(this.lblVectores);
            this.panel1.Location = new System.Drawing.Point(209, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 430);
            this.panel1.TabIndex = 9;
            // 
            // Vectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 430);
            this.Controls.Add(this.trvMenu);
            this.Controls.Add(this.dgvVector);
            this.Controls.Add(this.lblResultadoValor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblVector);
            this.Controls.Add(this.panel1);
            this.Name = "Vectores";
            this.Text = "Vectores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVectores;
        private System.Windows.Forms.Button btnDimensionar;
        private System.Windows.Forms.Label lblDimensionar;
        private System.Windows.Forms.TextBox tbxDimension;
        private System.Windows.Forms.Label lblVector;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoValor;
        private System.Windows.Forms.DataGridView dgvVector;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.Panel panel1;
    }
}