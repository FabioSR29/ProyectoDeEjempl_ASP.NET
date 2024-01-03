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
    public partial class AgregarNotas : Form
    {
        Estudiante ElEstudiante;
        public AgregarNotas(Estudiante nuevoEstudiante)
        {
            InitializeComponent();

            this.ElEstudiante = nuevoEstudiante;

            List<int> LaListaDenotas = ElEstudiante.ObtengaLaListaDeNotas();
            if(LaListaDenotas.Count!=0)
            foreach (var item in LaListaDenotas)
            {
                txtResultados.Text += item.ToString()+ "\r\n";
            }
        }

        private void btnAgregarUnaNota_Click(object sender, EventArgs e)
        {
            int nota = int.Parse(txtNotas.Text);

            ElEstudiante.AgregarNotas(nota);

            List<int> LaListaDenotas = ElEstudiante.ObtengaLaListaDeNotas();
            if (LaListaDenotas.Count != 0)
                txtResultados.Text = "";
                foreach (var item in LaListaDenotas)
                {
                    txtResultados.Text += item.ToString() + "\r\n";
                }
            txtNotas.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
