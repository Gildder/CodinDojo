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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Union de Conjuntos ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Intercepcion de conjuntos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Diferencia entre conjuntos {A}-{B}");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Diferencia entre conjuntos {B}-{A}");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Diferencia Simetrica");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Pertenece");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Salir");
            this.lblVectores = new System.Windows.Forms.Label();
            this.dgvVector = new System.Windows.Forms.DataGridView();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dgvVector
            // 
            this.dgvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVector.Location = new System.Drawing.Point(88, 72);
            this.dgvVector.Name = "dgvVector";
            this.dgvVector.Size = new System.Drawing.Size(506, 25);
            this.dgvVector.TabIndex = 7;
            this.dgvVector.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVector_CellContentClick);
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            treeNode1.Name = "Union de Conjuntos ";
            treeNode1.Text = "Union de Conjuntos ";
            treeNode2.Name = "Intercepcion de conjuntos";
            treeNode2.Text = "Intercepcion de conjuntos";
            treeNode3.Name = "Diferencia entre conjuntos {A}-{B}";
            treeNode3.Text = "Diferencia entre conjuntos {A}-{B}";
            treeNode4.Name = "Diferencia entre conjuntos {B}-{A}";
            treeNode4.Text = "Diferencia entre conjuntos {B}-{A}";
            treeNode5.Name = "Diferencia Simetrica";
            treeNode5.Text = "Diferencia Simetrica";
            treeNode6.Name = "Pertenece";
            treeNode6.Text = "Pertenece";
            treeNode7.Name = "Operaciones ";
            treeNode7.Text = "Operaciones";
            treeNode8.Name = "Salir";
            treeNode8.Text = "Salir";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.trvMenu.Size = new System.Drawing.Size(249, 430);
            this.trvMenu.TabIndex = 8;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dgvVector);
            this.panel1.Controls.Add(this.lblVectores);
            this.panel1.Location = new System.Drawing.Point(209, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 430);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(88, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(506, 25);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 25);
            this.dataGridView1.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVectores;
        private System.Windows.Forms.DataGridView dgvVector;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}