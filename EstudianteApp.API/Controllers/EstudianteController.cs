using EstudianteApp.Core.Models;
using EstudianteApp.Core.Services;

namespace EstudianteApp.API.Controllers
{
    public class EstudianteController
    {
        private readonly IEstudianteServicio _estudianteServicio;

        public EstudianteController(IEstudianteServicio estudianteServicio)
        {
            _estudianteServicio = estudianteServicio;
        }

        public string VerificarAprobacion(Estudiante estudiante)
        {
            return _estudianteServicio.Aprobado(estudiante) ? "Aprobado" : "Reprobado";
        }
    }
}