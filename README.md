# EstudianteApp.Tests

Este repositorio contiene una práctica académica desarrollada en .NET 6, enfocada en la implementación de **pruebas unitarias** utilizando técnicas de **Mocking** (con Moq) y **Stubbing**. La práctica gira en torno a una única entidad: `Estudiante`.

## 🎯 Objetivo

Aplicar pruebas unitarias en .NET mediante `xUnit`, simulando comportamientos con **Mocks** y **Stubs**, y probando la lógica de negocio del servicio `StudentService`.

## 🧠 Enunciado base

Imagina que estás desarrollando un sistema para la gestión de estudiantes de una institución educativa. Para esta práctica, se trabajará únicamente con la entidad `Estudiante`, que contiene:

```csharp
public class Estudiante
{
    public int CI { get; set; }
    public string Nombre { get; set; }
    public int Nota { get; set; }
}
