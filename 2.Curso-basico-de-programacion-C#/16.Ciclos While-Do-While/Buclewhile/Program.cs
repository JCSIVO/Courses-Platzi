System.Random random = new System.Random();
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// int totalJugador = 10; // Perdiste
// int totalJugador = 20; // Ganaste
int totalJugador = 0; // Condicion no valida
int totalDealer = 0;
int num = 0;
string message = "";
// string switchControl = "menu";
string switchControl = "menu";

// BlackJack, Juntar 21 pidiendo cartas, en caso de pasarte de 21 pierdes, o en caso de tener menos
// de 21 igual tener mayor puntación que el dealer

while (true)
{
    switch (switchControl)
    {

        case "menu":
            Console.WriteLine("Welcome al C a S i N o");
            Console.WriteLine("Escriba '21' para jugar al 21");
            switchControl = Console.ReadLine();
            break;

        case "21":
     do
      {
            
                num = random.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("Toma tu carta,");
                Console.WriteLine($"Te salio el número: {num} ");
                Console.WriteLine("¿Deseas otra carta?");


    } while (Console.ReadLine() == "Si" || Console.ReadLine() == "si" || Console.ReadLine() == "yes");

            if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste, le ganaste al Dealer, Felicidades";
                switchControl = "menu";
            }
            else if (totalJugador >= 22)
            {
                message = "Perdiste vs el dealer, lo siento, te pasaste de 21";
                switchControl = "menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = "Perdiste vs el dealer, lo siento";
                switchControl = "menu";
            }
            else
            {
                message = "Condición no válida";
            }

            Console.WriteLine(message);
            break;

        default:
            Console.WriteLine("Valor ingresado no valido en el casino");
            break;
    }
}