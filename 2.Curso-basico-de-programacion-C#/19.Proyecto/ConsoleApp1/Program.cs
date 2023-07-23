// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Console.WriteLine("---------------------------------------------------");
Console.WriteLine("| *- W E L C O M E  T O  | L A S  V E G A S | -*  |");


int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int apuesta = 0;
int HYCOINS = 0;
bool puedeApostar;
int FICHAS_RESTANTES = 0;
string seguirApostando;
string message = "";
string controlOtraCarta = "";
string switchControl;

System.Random random = new System.Random();


do
{
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|$|");
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("\n ¿ C U A N T A S  F I C H A S  Q U I E R E S ?");
    Console.WriteLine("");
    HYCOINS = int.Parse(Console.ReadLine());
    HYCOINS = HYCOINS + FICHAS_RESTANTES;

    do
    {
        do
        {
            totalJugador = 0;
            totalDealer = 0;
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| T I E N E S  U N  T O T A L  D E " + " | "
            + HYCOINS + " $ " + " H Y C O I NS (^_^)  |");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("\n ¿ C U A N T O S  $ HYCOINS $  Q U I E R E S  A P O S T A R ? (O_o)");
            Console.WriteLine("");
            apuesta = int.Parse(Console.ReadLine());
            if (apuesta > HYCOINS)
            {
                Console.WriteLine("");
                Console.WriteLine(" N O  T I E N E S  S U F I C I E N T E S  C R E D I T O S  (>.<) ");
                puedeApostar = false;
            }
            else
            {
                puedeApostar = true;
            }

        } while (puedeApostar != true);
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("| E S C R I B A |21| P A R A  E M P E Z A R  A  J U G A R  (^_^) |");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
        switchControl = Console.ReadLine();

        if (switchControl == "21")
        {
            do
            {
                num = random.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"| T E  S A L I O  E L  N U M E R O : {num} |");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("\n ¿ D E S E A S  O T R A  C A R T A ? ");
                Console.WriteLine("");
                controlOtraCarta = Console.ReadLine();

            } while (controlOtraCarta == "SI" ||
                     controlOtraCarta == "si" ||
                     controlOtraCarta == "yes");
        }

        totalDealer = random.Next(15, 23);
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"| E L  D E A L E R  T I E N E | {totalDealer} | C A R T A S (>.<) |");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("");

        if (totalJugador > totalDealer && totalJugador < 22)
        {
            message = " V E N C I S T E  A L  D E A L E R, F E L I C I D A D E S  (^_^) ";
            HYCOINS += apuesta;
            Console.WriteLine(message);
        }
        else if (totalJugador >= 22)
        {
            message = " P E R D I S T E  VS  E L  D E A L E R, L O  S I E N T O  (>.<) ";
            HYCOINS -= apuesta;
            Console.WriteLine(message);
        }
        else if (totalJugador <= totalDealer)
        {
            message = "P E R D I S T E  VS  E L  D E A L E R, L O  S I E N T O  (>.<) ";
            HYCOINS -= apuesta;
            Console.WriteLine(message);
        }
        else
        {
            message = " C O N D I C I O N  N O  V A L I D A (>.<) ";
        }
        Console.WriteLine("");
        Console.WriteLine("------------------------------");
        Console.WriteLine("| T I E N E S " + HYCOINS + " F I C H A S |");
        Console.WriteLine("------------------------------");
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("| ¿ D E S E A S  S E G U I R  A P O S T A N D O ? |");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("");
        seguirApostando = Console.ReadLine();

        FICHAS_RESTANTES = +HYCOINS;
        Console.Clear();
        if (HYCOINS == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("| S I N  C R E D I T O S, P O R  F A V O R  C O M P R A  M A S... |");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("");
            break;
        }
    } while (seguirApostando == "si" || seguirApostando == "SI");
    Console.WriteLine("");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("| ¿ Q U I E R E S  S A L I R  D E L  C A S I N O ? |");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("");
    seguirApostando = Console.ReadLine();
    if (seguirApostando == "si" || seguirApostando == "SI")
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("| G R A C I A S  P O R  J U G A R  (^_^) |");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("");
        Console.ReadKey();
    }
    else
    {
        Console.Clear();
    }
} while (seguirApostando == "no" || seguirApostando == "NO");