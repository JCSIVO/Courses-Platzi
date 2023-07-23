// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Operadores logicos
// &&
// ||
// !
// ^

// bool valor1 = true;
// bool valor2 = true;
// bool valor3 = false;

var (valor1, valor2, valor3) = (true, true, false);

bool resultadoAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultadoAnd);

bool resultado2Or = valor1 || valor2 || valor3;
Console.WriteLine(resultado2Or);

bool resultado3AndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultado3AndOr);

bool resultadoNot = !valor1;
Console.WriteLine(resultadoNot);

bool resultadoXor = valor1 ^ valor2 ^ valor3; // Comprueba si los valores son diferentes
Console.WriteLine(resultadoXor);

