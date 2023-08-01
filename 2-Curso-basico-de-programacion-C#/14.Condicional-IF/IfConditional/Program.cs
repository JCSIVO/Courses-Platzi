// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// int totalJugador = 10; // Perdiste
// int totalJugador = 20; // Ganaste
int totalJugador = 25; // Condicion no valida
int totalDealer = 15;
string message = "";

// BlackJack, Juntar 21 pidiendo cartas, en caso de pasarte de 21 pierdes, o en caso de tener menos
// de 21 igual tener mayor puntación que el dealer

if (totalJugador > totalDealer && totalJugador < 22)
{
    message = "Venciste, le ganaste al Dealer, Felicidades";
}
else if ( totalJugador >= 22)
{
    message = "Perdiste vs el dealer, lo siento, te pasaste de 21";
}
else if (totalJugador <= totalDealer)
{
    message = "Perdiste vs el dealer, lo siento";
}
else
{
    message = "Condición no válida";
}

Console.WriteLine(message);