using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Conjunto : Form
    {
        RNConjunto resultado;
        RNConjunto conjuntoA;
        RNConjunto conjuntoB;
        Random randon = new Random();

        public Conjunto()
        {
            InitializeComponent();

            
            resultado = new RNConjunto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblVectores_Click(object sender, EventArgs e)
        {

        }

        private void dgvVector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Conjunto_Load(object sender, EventArgs e)
        {

        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            
            if((!tbxDimensionA.Text.Equals("")) || (!tbxDimensionB.Text.Equals("")))
            {
                if((Convert.ToInt32(tbxDimensionA.Text) > 100) || (Convert.ToInt32(tbxDimensionA.Text) > 100))
                {
                    MessageBox.Show("El Limite es 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DimensionarA(Convert.ToInt32(tbxDimensionA.Text));
                    DimensionarB(Convert.ToInt32(tbxDimensionB.Text));

                    LimpiarVectorA();
                    LimpiarVectorB();

                    DibujarA();
                    DibujarB();
                }
            }
            else
            {
                MessageBox.Show("Por favor, Introduce el de los conjuntos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LimpiarVectorB()
        {
            for(int i = dgvConjuntoB.Columns.Count - 1; i >= 0; i--)
            {
                dgvConjuntoB.Columns.RemoveAt(i);
            }
        }

        private void LimpiarVectorA()
        {
            for(int i = dgvConjuntoA.Columns.Count - 1; i >= 0; i--)
            {
                dgvConjuntoA.Columns.RemoveAt(i);
            }
        }

        private void DibujarA()
        {
            for(int i = 0; i < conjuntoA.Pn; i++)
            {
                dgvConjuntoA.Columns.Add(Convert.ToString(i), Convert.ToString(i));

                if(dgvConjuntoA.Columns.Count == 1)
                    dgvConjuntoA.Rows.Add();

                dgvConjuntoA[i, 0].Value = conjuntoA.LeerVector(i).Num;
            }
        }

        private void DibujarB()
        {
            for(int i = 0; i < conjuntoB.Pn; i++)
            {
                dgvConjuntoB.Columns.Add(Convert.ToString(i), Convert.ToString(i));

                if(dgvConjuntoB.Columns.Count == 1)
                    dgvConjuntoB.Rows.Add();

                dgvConjuntoB[i, 0].Value = conjuntoB.LeerVector(i).Num;
            }
        }

        private void DimensionarA(int n)
        {
            conjuntoA = new RNConjunto();
            for(int i = 0; i < n; i++)
            {
                conjuntoA.Insertar(i, randon.Next(1, 100));
            }
        }

        private void DimensionarB(int n)
        {
            conjuntoB = new RNConjunto();

            for(int i = 0; i < n; i++)
            {
                conjuntoB.Insertar(i, randon.Next(1, 100));
            }
        }
    }
}
