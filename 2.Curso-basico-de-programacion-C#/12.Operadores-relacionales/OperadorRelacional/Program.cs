// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// == igual a 
// != diferente a 
//  > mayor que 
// < menor que 
// >= mayor o igual
// <= menor o igual

// var (valor1, valor2, valor3) = (10, 1, 2);

var (valor1, valor2, valor3) = (10, 10, 2);

Console.WriteLine("Los valores son los siguientes: " + "Valor1: " + valor1 + " Valor2: " + valor2 + " Valor3: " + valor3);

bool resultado1 = valor1 == valor2;
Console.WriteLine("El resultado de la comparación valor1 == valor2 es: " + resultado1);

bool resultado2 = valor1 != valor2;
Console.WriteLine("El resultado de la comparación valor1 != valor2 es: " + resultado2);

bool resultado3 = valor1 > valor2;
Console.WriteLine("El resultado de la comparación valor1 > valor2 es: " + resultado3);

bool resultado4 = valor1 < valor2;
Console.WriteLine("El resultado de la comparación valor1 < valor2 es: " + resultado4);

bool resultado5 = valor1 >= valor2;
Console.WriteLine("El resultado de la comparación valor1 >= valor2 es: " + resultado5);

bool resultado6 = valor1 <= valor2;
Console.WriteLine("El resultado de la comparación valor1 <= valor2 es: " + resultado6);
