// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Humanizer;

Console.Write("Por favor ingrese un nombre: ");
var nombre = Console.ReadLine();

Console.Write("Por favor ingrese su cargo: ");
var cargo = Console.ReadLine();

Console.Write("Por favor ingrese su edad: ");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, Mi nombre es : { nombre }, mi cargo es { cargo } y tengo { edad.ToWords(new System.Globalization.CultureInfo("en")) } años");


// Comandos importantes 

// para ver la lista de templates de proyectos
// dotnet new --list

// para crear un proyecto
// dotnet new < tipo - proyecto >   # ej. dotnet new console: crea una aplicacion de consola

// para hacer correr nuestro proyecto
// dotnet run

// compila un proyecto y todas sus dependencias, tambien verificar que toda la sintaxis este bien y no se tengan problemas con dependencias
// dotnet build

// sirve restaurar las dependencias y las herramientas de un proyecto.
// dotnet restore

// nos permite ejecutar el proyecto y va revisando los cambios del proyecto en tiempo real (similar a nodemon en node)
// dotnet watch run

// Para limpiar la compilación hecha, podemos usar el comando:
// dotnet clean

// Para depurar el proyecto
// dotnet build configuration debug

// Compilación mas optima
// dotnet build configuration release

// Archivo Global JSON: Es un archivo que nos permite administrar las versiones los SDK que trabajamos en .NET
// dotnet new globaljson

// Revisar las versiones que tenemos en nuestro equipo
// dotnet info

// Si solo necesitan todos los mensajes en Español, pueden instalar la librería Humanizer en Español
// dotnet add package Humanizer --version 2.14.1

// Para cambiar el idioma
// new System.Globalization.CultureInfo("en") -> español "es"
