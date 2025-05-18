using EstudianteApp.Core.Models;

namespace EstudianteApp.Core.Services
{
    public interface IStudentService
    {
        bool esAprobado(Estudiante estudiante);
    }
}