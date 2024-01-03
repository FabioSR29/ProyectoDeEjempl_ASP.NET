using GestorDeEstudiantes.logica;

namespace GestorDeEstudiantes.UI
{
    public partial class Home : Form
    {
        public libroDeEstudiantes LaLista { get; set; }
        public Home()
        {
            InitializeComponent();
            LaLista = new libroDeEstudiantes();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEstudiante frmAgregar = new AgregarEstudiante();
            frmAgregar.ShowDialog();

            if (frmAgregar.DialogResult == DialogResult.OK)
            {
                LaLista.AgregarEstudiantesAlaLista(frmAgregar.ElEstudiante);
                MostrarLaListaEstudiantes();
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            List<Estudiante> LosEstudiantes = LaLista.ObtengaLaListaDeEstudiantes(); 

            if (LosEstudiantes.Count!=0)
            {
                DetalleDelEstudiante frmDetalle = new DetalleDelEstudiante(ObtenerEstudiante());
                frmDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aun no se han registrado estudiantes.", "sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void MostrarLaListaEstudiantes()
        {
            DGV.DataSource = null;
            DGV.DataSource = LaLista.ObtengaLaListaDeEstudiantes();
        }

        Estudiante ObtenerEstudiante()
        {

            Estudiante elEstudiante = DGV.CurrentRow.DataBoundItem as Estudiante;
            return elEstudiante;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int identificacion = int.Parse(txtBuscar.Text);
            List<Estudiante> ListaDeEstudiantes = LaLista.ObtengaLaListaDeEstudiantes();
            List<Estudiante> ListaDeResultadosDeBusqueda = new List<Estudiante>();

            foreach (var item in ListaDeEstudiantes)
            {
                if (item.identificacion == identificacion)
                {
                    ListaDeResultadosDeBusqueda.Add(item);


                }
            }


            if (ListaDeResultadosDeBusqueda.Count == 0)
            { MessageBox.Show("No se encontro la persona que buscas.", "No hubiero conincidencias", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {

                DGV.DataSource = null;
                DGV.DataSource = ListaDeResultadosDeBusqueda;
            }


        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            
            List<Estudiante> LosEstudiantes = LaLista.ObtengaLaListaDeEstudiantes();

            if (LosEstudiantes.Count != 0) { 
                AgregarNotas frmAgregarNotas = new AgregarNotas(ObtenerEstudiante());
                frmAgregarNotas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aun no se han registrado estudiantes.", "sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
