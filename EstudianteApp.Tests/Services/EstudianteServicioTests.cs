using EstudianteApp.Core.Models;
using EstudianteApp.Core.Services;

namespace EstudianteApp.Tests.Services
{
    public class EstudianteServicioTests
    {
        [Fact]
        public void Aprobo_DeberiaRetornarTrue_CuandoNotaEsMayorOIgualA51()
        {
            var estudiante = new Estudiante() { CI = 123, Nombre = "Juan", Nota = 70 };
            var servicio = new EstudianteServicio();

            var resultado = servicio.Aprobado(estudiante);

            Assert.True(resultado);
        }

        [Fact]
        public void Aprobo_DeberiaRetornarFalse_CuandoNotaEsMenorA51()
        {
            var estudiante = new Estudiante { CI = 456, Nombre = "Ana", Nota = 40 };
            var servicio = new EstudianteServicio();

            var resultado = servicio.Aprobado(estudiante);

            Assert.False(resultado);
        }

        [Fact]
        public void Estudiante_DeberiaConservarElNombre()
        {
            var estudiante = new Estudiante { CI = 789, Nombre = "Carlos", Nota = 80 };

            Assert.Equal("Carlos", estudiante.Nombre);
        }

        [Fact]
        public void Estudiante_DeberiaConservarElCI()
        {
            var estudiante = new Estudiante { CI = 101, Nombre = "Lucía", Nota = 90 };

            Assert.Equal(101, estudiante.CI);
        }
    }
}