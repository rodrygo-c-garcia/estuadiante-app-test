using EstudianteApp.Core.Models;
using EstudianteApp.Core.Services;

namespace EstudianteApp.Tests.Stubs
{
    public class EstudianteServicioStub : IEstudianteServicio
    {
        private readonly bool _aprobado;

        public EstudianteServicioStub(bool aprobado)
        {
            _aprobado = aprobado;
        }

        public bool Aprobado(Estudiante estudiante)
        {
            return _aprobado;
        }
    }
}