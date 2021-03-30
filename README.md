# Programación III 2021

## Herramientas utilizadas en éste proyecto

- PlantUML - [UML processor](https://plantuml.com/es/download) - [Diagramas de clases](https://plantuml.com/es/class-diagram)
- PlantUML support for Visual Studio Code - [VS Marketplace](https://marketplace.visualstudio.com/items?itemName=jebbs.plantuml)
- Markdown - [Sintáxis básica](https://www.markdownguide.org/basic-syntax/)
- [Visual Studio Code](https://code.visualstudio.com/)
- Ubuntu 20.04
- .Net Core for Ubuntu - [Guía Oficial](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu#2004-)
- C# for Visual Studio Code (powered by OmniSharp). [VS Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
- [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) - Una guía sobre como realizar commits en un proyecto.

### Hello World Example

Primero creamos una carpeta donde alojar a nuestro proyecto:
```
$ mkdir hello-world
```
Nos movemos de directorio e inicializamos el versionado:
```
$ cd hello-world && git init
```
Creamos nuestro proyecto de consola:
```
$ dotnet new console
```
Agregamos un archivo gitinore para que ignore determinados files que no necesitan ser versionados:
```
$ dotnet new gitignore
```
Ejecutamos la aplicación:
```
$ dotnet run
```
**Nota:** Para otros templates se puede consultar el manual del siguiente modo: `dotnet new -l`