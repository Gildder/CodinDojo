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
    public partial class Numeros : Form
    {
        Negocio.RNEntero N = new Negocio.RNEntero();
        public Numeros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblVectores_Click(object sender, EventArgs e)
        {

        }

        private void Numeros_Load(object sender, EventArgs e)
        {

        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                N.Num = Int32.Parse(tbxNumero.Text);
                if (N.Primo())
                {
                    MessageBox.Show("Es Primo");
                }
                else
                {
                    MessageBox.Show("No es Primo");
                }
            }
            catch
            {
                MessageBox.Show("Hubo un Error en la Funcion, Intente de Nuevo");
            }
        }

        private void txbNumero(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
