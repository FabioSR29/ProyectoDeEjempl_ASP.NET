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
    public partial class AgregarEstudiante : Form
    {
        public logica.Estudiante ElEstudiante { get; set; }
        public AgregarEstudiante()
        {
            InitializeComponent();
            ElEstudiante = new logica.Estudiante();
        }

       

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            ElEstudiante.nombre = txtNombre.Text;
            ElEstudiante.apellidos = txtApellido.Text;
            ElEstudiante.identificacion = int.Parse(txtIdentificacion.Text);
           
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.DialogResult= DialogResult.Cancel;
        }
    }
}
