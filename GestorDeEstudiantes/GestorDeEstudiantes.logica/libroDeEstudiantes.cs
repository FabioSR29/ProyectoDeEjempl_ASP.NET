using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudiantes.logica
{
    public class libroDeEstudiantes
    {

        private List<Estudiante> LaListaDeEstudiantes { get; set; }

        public libroDeEstudiantes()
        {
            LaListaDeEstudiantes = new List<Estudiante>();
        }



     public   void AgregarEstudiantesAlaLista(Estudiante elEstudiante) {
            LaListaDeEstudiantes.Add(elEstudiante);
        }

      public  List<Estudiante> ObtengaLaListaDeEstudiantes() { 
        return LaListaDeEstudiantes;
        }


    }
}
