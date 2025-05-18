using EstudianteApp.Core.Models;

namespace EstudianteApp.Core.Services
{
    public interface IEstudianteServicio
    {
        bool Aprobado(Estudiante estudiante);
    }
}