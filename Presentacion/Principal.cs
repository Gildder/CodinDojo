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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void mtsNumeros_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Numeros>().FirstOrDefault();
            Numeros hijo = form ?? new Numeros();
            AddFormInPanel(hijo);
        }

        /// <summary>
        /// Agrega en un Panel un formulario
        /// </summary>
        /// <param name="formHijo">Instancia del formulario a agregar</param>
        private void AddFormInPanel(Form formHijo)
        {
            if(this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void mtsVectores_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Vectores>().FirstOrDefault();
            Vectores hijo = form ?? new Vectores();
            AddFormInPanel(hijo);
        }

        private void mtsConjuntos_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Conjunto>().FirstOrDefault();
            Conjunto hijo = form ?? new Conjunto();
            AddFormInPanel(hijo);
        }
    }
}
