namespace GestorDeEstudiantes.logica
{
    public class Estudiante
    {

        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int identificacion { get; set; }

        public List<int>? notas { get; set; }

        public Estudiante()
        {
            notas = new List<int>();
        }


        public void AgregarNotas(int nota)
        {
            notas.Add(nota);
        }

        public List<int>? ObtengaLaListaDeNotas()
        {
            return notas;
        }

    }
}
