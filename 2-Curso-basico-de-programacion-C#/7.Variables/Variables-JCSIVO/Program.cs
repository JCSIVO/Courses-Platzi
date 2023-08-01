// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Programadores!");


Console.WriteLine("Programa para calcular el area de un rectangulo");
// Programa que calcula el area de un rectangulo
// int ladoA; // Declaraicón de variables
// int ladoB;
// int Resultado;

//double ladoA; // Declaraicón de variables
//double ladoB;
//double Resultado;

var ladoA = 0d; // Declaraicón de variables
var ladoB = 0d;
var Resultado = 0d;

Console.WriteLine("Calcula el area de un rectangulo");
Console.Write("Ingrese el valor del lado A: ");
// ladoA = Convert.ToInt32(Console.ReadLine());
ladoA = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor del lado B: ");
// ladoB = Convert.ToInt32(Console.ReadLine());
ladoB = Convert.ToDouble(Console.ReadLine());

// ladoA++; // "Operador de incremento" Incremanta en uno al valor de A
ladoA = ladoA + 1; // Esto sustituye a las lineas de arriba y abajo
// ladoA--; // "Operado de decremento" Decrementa en 1 el valor de A 

// Formula para un triangulo rectangulo
// Resultado = (ladoA * ladoB)/2;

// Resto de la división -> %
// Suma -> +
// Resta -> -


Resultado = ladoA * ladoB;
Console.WriteLine("El resultado es: " + Resultado);
Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + Resultado);
