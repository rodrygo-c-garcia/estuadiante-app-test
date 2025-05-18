using EstudianteApp.API.Controllers;
using EstudianteApp.Core.Models;
using EstudianteApp.Core.Services;
using Moq;

namespace EstudianteApp.Tests.Controllers
{
    public class ControladorEstudianteTests
    {
        [Fact]
        public void VerificarAprobacion_DeberiaRetornarAprobado_CuandoServicioDevuelveTrue()
        {
            var mockServicio = new Mock<IEstudianteServicio>();
            var estudiante = new Estudiante { CI = 123, Nombre = "Pedro", Nota = 80 };

            mockServicio.Setup(s => s.Aprobado(estudiante)).Returns(true);

            var controlador = new EstudianteController(mockServicio.Object);

            var resultado = controlador.VerificarAprobacion(estudiante);

            Assert.Equal("Aprobado", resultado);
        }

        [Fact]
        public void VerificarAprobacion_DeberiaRetornarReprobado_CuandoServicioDevuelveFalse()
        {
            var mockServicio = new Mock<IEstudianteServicio>();
            var estudiante = new Estudiante() { CI = 456, Nombre = "Luis", Nota = 40 };

            mockServicio.Setup(s => s.Aprobado(estudiante)).Returns(false);

            var controlador = new EstudianteController(mockServicio.Object);

            var resultado = controlador.VerificarAprobacion(estudiante);

            Assert.Equal("Reprobado", resultado);
        }
    }
}