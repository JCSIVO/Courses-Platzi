// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Irene Sanchez ID!");
int altura = 160;
int edad = 25;
string nombre = "Irene Sanchez";
string informacion = "Nació en Murcia, es estudiante de enfermeria y medicina";
var hobby = "Deportista";

string tarjetaDeIdentificacion = $"La información de Irense Sanchez tiene altura de 168 y edad 25";
Console.WriteLine(tarjetaDeIdentificacion);

string tarjetaDeIdentificacion2 = $"La información de {nombre} \n" + 
    $"\n es la siguiente, su edad es {edad}\n y tiene una altura de {altura} cm \n información relavante {informacion}\n";
Console.WriteLine(tarjetaDeIdentificacion2);