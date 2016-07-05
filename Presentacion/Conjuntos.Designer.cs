namespace Presentacion
{
    partial class Conjunto
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Union de Conjuntos ");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Intercepcion de conjuntos");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Diferencia entre conjuntos {A}-{B}");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Diferencia entre conjuntos {B}-{A}");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Diferencia Simetrica");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Pertenece");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Salir");
            this.lblVectores = new System.Windows.Forms.Label();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnDimensionar = new System.Windows.Forms.Button();
            this.tbxDimensionA = new System.Windows.Forms.TextBox();
            this.lblDimensionar = new System.Windows.Forms.Label();
            this.tbxDimensionB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConjuntoA = new System.Windows.Forms.DataGridView();
            this.dgvConjuntoB = new System.Windows.Forms.DataGridView();
            this.dgvConjuntoR = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntoR)).BeginInit();
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
            this.lblVectores.Size = new System.Drawing.Size(136, 24);
            this.lblVectores.TabIndex = 0;
            this.lblVectores.Text = "CONJUNTOS";
            this.lblVectores.Click += new System.EventHandler(this.lblVectores_Click);
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            treeNode17.Name = "Union de Conjuntos ";
            treeNode17.Text = "Union de Conjuntos ";
            treeNode18.Name = "Intercepcion de conjuntos";
            treeNode18.Text = "Intercepcion de conjuntos";
            treeNode19.Name = "Diferencia entre conjuntos {A}-{B}";
            treeNode19.Text = "Diferencia entre conjuntos {A}-{B}";
            treeNode20.Name = "Diferencia entre conjuntos {B}-{A}";
            treeNode20.Text = "Diferencia entre conjuntos {B}-{A}";
            treeNode21.Name = "Diferencia Simetrica";
            treeNode21.Text = "Diferencia Simetrica";
            treeNode22.Name = "Pertenece";
            treeNode22.Text = "Pertenece";
            treeNode23.Name = "Operaciones ";
            treeNode23.Text = "Operaciones";
            treeNode24.Name = "Salir";
            treeNode24.Text = "Salir";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            this.trvMenu.Size = new System.Drawing.Size(249, 430);
            this.trvMenu.TabIndex = 8;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvConjuntoR);
            this.panel1.Controls.Add(this.dgvConjuntoB);
            this.panel1.Controls.Add(this.dgvConjuntoA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxDimensionB);
            this.panel1.Controls.Add(this.btnDimensionar);
            this.panel1.Controls.Add(this.tbxDimensionA);
            this.panel1.Controls.Add(this.lblDimensionar);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Controls.Add(this.lblVectores);
            this.panel1.Location = new System.Drawing.Point(245, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 430);
            this.panel1.TabIndex = 9;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(23, 136);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(32, 17);
            this.lblA.TabIndex = 10;
            this.lblA.Text = "A =";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(23, 224);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(32, 17);
            this.lblB.TabIndex = 11;
            this.lblB.Text = "B =";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(23, 316);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(33, 17);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "R =";
            // 
            // btnDimensionar
            // 
            this.btnDimensionar.Location = new System.Drawing.Point(441, 93);
            this.btnDimensionar.Name = "btnDimensionar";
            this.btnDimensionar.Size = new System.Drawing.Size(75, 23);
            this.btnDimensionar.TabIndex = 13;
            this.btnDimensionar.Text = "Dimensionar";
            this.btnDimensionar.UseVisualStyleBackColor = true;
            this.btnDimensionar.Click += new System.EventHandler(this.btnDimensionar_Click);
            // 
            // tbxDimensionA
            // 
            this.tbxDimensionA.Location = new System.Drawing.Point(229, 98);
            this.tbxDimensionA.Name = "tbxDimensionA";
            this.tbxDimensionA.Size = new System.Drawing.Size(100, 20);
            this.tbxDimensionA.TabIndex = 15;
            this.tbxDimensionA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDimensionA_KeyPress);
            // 
            // lblDimensionar
            // 
            this.lblDimensionar.AutoSize = true;
            this.lblDimensionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensionar.Location = new System.Drawing.Point(23, 99);
            this.lblDimensionar.Name = "lblDimensionar";
            this.lblDimensionar.Size = new System.Drawing.Size(200, 17);
            this.lblDimensionar.TabIndex = 14;
            this.lblDimensionar.Text = "Numero para dimensionar:";
            // 
            // tbxDimensionB
            // 
            this.tbxDimensionB.Location = new System.Drawing.Point(335, 99);
            this.tbxDimensionB.Name = "tbxDimensionB";
            this.tbxDimensionB.Size = new System.Drawing.Size(100, 20);
            this.tbxDimensionB.TabIndex = 16;
            this.tbxDimensionB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDimensionB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "B";
            // 
            // dgvConjuntoA
            // 
            this.dgvConjuntoA.AllowUserToAddRows = false;
            this.dgvConjuntoA.AllowUserToDeleteRows = false;
            this.dgvConjuntoA.AllowUserToResizeColumns = false;
            this.dgvConjuntoA.AllowUserToResizeRows = false;
            this.dgvConjuntoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConjuntoA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvConjuntoA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvConjuntoA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConjuntoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConjuntoA.Location = new System.Drawing.Point(90, 136);
            this.dgvConjuntoA.Name = "dgvConjuntoA";
            this.dgvConjuntoA.ReadOnly = true;
            this.dgvConjuntoA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvConjuntoA.Size = new System.Drawing.Size(506, 73);
            this.dgvConjuntoA.TabIndex = 19;
            // 
            // dgvConjuntoB
            // 
            this.dgvConjuntoB.AllowUserToAddRows = false;
            this.dgvConjuntoB.AllowUserToDeleteRows = false;
            this.dgvConjuntoB.AllowUserToResizeColumns = false;
            this.dgvConjuntoB.AllowUserToResizeRows = false;
            this.dgvConjuntoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConjuntoB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvConjuntoB.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvConjuntoB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConjuntoB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConjuntoB.Location = new System.Drawing.Point(90, 224);
            this.dgvConjuntoB.Name = "dgvConjuntoB";
            this.dgvConjuntoB.ReadOnly = true;
            this.dgvConjuntoB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvConjuntoB.Size = new System.Drawing.Size(506, 73);
            this.dgvConjuntoB.TabIndex = 20;
            // 
            // dgvConjuntoR
            // 
            this.dgvConjuntoR.AllowUserToAddRows = false;
            this.dgvConjuntoR.AllowUserToDeleteRows = false;
            this.dgvConjuntoR.AllowUserToResizeColumns = false;
            this.dgvConjuntoR.AllowUserToResizeRows = false;
            this.dgvConjuntoR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConjuntoR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvConjuntoR.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvConjuntoR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConjuntoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConjuntoR.Location = new System.Drawing.Point(90, 316);
            this.dgvConjuntoR.Name = "dgvConjuntoR";
            this.dgvConjuntoR.ReadOnly = true;
            this.dgvConjuntoR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvConjuntoR.Size = new System.Drawing.Size(506, 73);
            this.dgvConjuntoR.TabIndex = 21;
            // 
            // Conjunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 430);
            this.Controls.Add(this.trvMenu);
            this.Controls.Add(this.panel1);
            this.Name = "Conjunto";
            this.Text = "Conjuntos";
            this.Load += new System.EventHandler(this.Conjunto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjuntoR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVectores;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDimensionB;
        private System.Windows.Forms.Button btnDimensionar;
        private System.Windows.Forms.TextBox tbxDimensionA;
        private System.Windows.Forms.Label lblDimensionar;
        private System.Windows.Forms.DataGridView dgvConjuntoA;
        private System.Windows.Forms.DataGridView dgvConjuntoB;
        private System.Windows.Forms.DataGridView dgvConjuntoR;
    }
}