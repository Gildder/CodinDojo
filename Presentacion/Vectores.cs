using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Vectores : Form
    {
        RNVectorEntero vector;

        public Vectores()
        {
            InitializeComponent();

            

        }
     
        private void tbxDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.OnlyNumeric(e);
        }

        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            if(btnDimensionar.Text == "Buscar")
            {
                Boolean pos= vector.Existe(Convert.ToInt32(tbxDimension.Text));
                PintarElemento(pos);
                AdaptarInterfaz();
                return;
            }

            if(!tbxDimension.Text.Equals(""))
            {
                if(Convert.ToInt32(tbxDimension.Text) > 100)
                {
                    MessageBox.Show("El Limite es 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Dimensionar(Convert.ToInt32(tbxDimension.Text));
                    LimpiarVector();
                    lblResultadoValor.Text = "#";
                    Cargar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, Introduce un valor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void PintarElemento(Boolean pos)
        {
            if(pos)
                MessageBox.Show("Elemento exite!", "Resultado de Busqueda", MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Elemento NO exite!", "Resultado de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Dimensionar(Int32 n)
        {
            vector = new RNVectorEntero();
            Random randon = new Random();

            for(int i = 0; i < n; i++)
            {
                vector.Insertar(i,randon.Next(1, 254));
            }
        }


        public void Cargar()
        {
            for(int i = 0; i < vector.Pn; i++)
            {
                dgvVector.Columns.Add(Convert.ToString(i), Convert.ToString(i));

                if(dgvVector.Columns.Count == 1)
                    dgvVector.Rows.Add();

                dgvVector[i, 0].Value = vector.LeerVector(i).Num;
            }
        }

        public void LimpiarVector()
        {
            for(int i = dgvVector.Columns.Count - 1; i >= 0; i--)
            {
                dgvVector.Columns.RemoveAt(i);
            }

        }

        private void trvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(vector.Pn == 0 && e.Node.Name != "Operaciones" && e.Node.Name != "Salir")
            {
                MessageBox.Show("Por favor, dimensionar el Vector", "Advertencias", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            lblResultadoValor.Text = "#";
            switch(e.Node.Name)
            {
                case "ContarCapicuas":
                    vector.ContarCapicuaVector();
                    lblResultadoValor.Text = vector.ContarCapicuaVector().ToString();
                    break;
                case "ContarPrimos":
                    vector.ContarPrimosVector();
                    lblResultadoValor.Text = vector.ContarPrimosVector().ToString();
                    break;
                case "OrdenarVector":
                    LimpiarVector();
                    vector.Ordenar();
                    Cargar();
                    break;
                case "EliminarCapicuas":
                    LimpiarVector();
                    vector.EliminarCapicuas();
                    Cargar();
                    break;
                case "EliminarRepetidos":
                    LimpiarVector();
                    vector.EliminarRepetidos();
                    Cargar();
                    break;
                case "EliminarPrimos":
                    LimpiarVector();
                    vector.EliminarPrimos();
                    Cargar();
                    break;
                case "BuscarElemento":
                    AdaptarInterfaz();
                    break;
                case "Salir":
                    Close();
                    break;
                default:
                    break;
            }

        }

        private void AdaptarInterfaz()
        {
            if(btnDimensionar.Text != "Buscar")
            {
                lblDimensionar.Text = "Elemento a buscar";
                btnDimensionar.Text = "Buscar";
                tbxDimension.Text = "";
            }
            else
            {
                lblDimensionar.Text = "Numero para dimensionar";
                btnDimensionar.Text = "Dimensionar";
                tbxDimension.Text = "";
            }
        }


    }
}
