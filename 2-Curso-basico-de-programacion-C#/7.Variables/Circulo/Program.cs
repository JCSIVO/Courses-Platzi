// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


var radio = 0d;
var resultado = 0d;
// var resultadoCirculo = 0d -> CamelCase

const double Pi = 3.14;

Console.WriteLine("Bienvenido, tratemos de calcular los circulos");
// PI * radio * radio
Console.Write("Ingresa el valor del radio: ");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;

Console.WriteLine("El area de tuy ciirculo es de: " + resultado);