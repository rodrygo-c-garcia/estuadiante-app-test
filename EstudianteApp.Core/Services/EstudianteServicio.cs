using EstudianteApp.Core.Models;

namespace EstudianteApp.Core.Services
{
    public class EstudianteServicio : IEstudianteServicio
    {
        public bool Aprobado(Estudiante estudiante)
        {
            if (estudiante == null)
            {
                throw new ArgumentNullException(nameof(estudiante), "El estudiante no puede ser nulo.");
            }

            if (estudiante.Nota < 0 || estudiante.Nota > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(estudiante.Nota), "La nota debe estar entre 0 y 100.");
            }

            if (string.IsNullOrWhiteSpace(estudiante.Nombre))
            {
                throw new ArgumentException("El nombre del estudiante no puede estar vacío.",
                    nameof(estudiante.Nombre));
            }

            if (estudiante.CI <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(estudiante.CI), "La CI debe ser un número positivo.");
            }

            return estudiante.Nota >= 51;
        }
    }
}