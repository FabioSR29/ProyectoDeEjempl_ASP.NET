using GestorDeEstudiantes.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudiantes.UI
{
    public partial class DetalleDelEstudiante : Form
    {
        public DetalleDelEstudiante(Estudiante ElEstudiante)
        {
            InitializeComponent();

            txtNombre.Text = ElEstudiante.nombre;
            txtApellido.Text = ElEstudiante.apellidos;
            txtIdentificacion.Text = ElEstudiante.identificacion.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
