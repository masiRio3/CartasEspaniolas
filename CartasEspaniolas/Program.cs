
using CartasEspaniolas.Modelos;


var baraja1 = new Baraja();

string valorEntrada = "0";

do
{
    Console.WriteLine("                  ---BARAJA DE CARTAS DEL PROFE EUGENIO---                  ");
    Console.WriteLine("============================================================================");
    Console.WriteLine("PUEDE REALIZAR LAS SIGUIENTES OPCIONES PRESIONANDO EL NUMERO CORRESPONDIENTE");
    Console.WriteLine("1- Barajar el maso");
    Console.WriteLine("2- Mostrar la siguiente carta");
    Console.WriteLine("3- Mostrar las cartas disponibles");
    Console.WriteLine("4- Dar cartas");
    Console.WriteLine("5- Mostrar las cartas del monton");
    Console.WriteLine("6- Mostrar la baraja");
    Console.WriteLine("7- Salir");
    Console.WriteLine("============================================================================");
    Console.Write("Opcion ingresada: ");

    valorEntrada = Console.ReadLine();

    //while (valorEntrada<1 || valorEntrada>7)
    //{
    //    Console.WriteLine("Opcion incorrecta, por favor ingrese una opcion valida");
    //    valorEntrada = int.Parse(Console.ReadLine());

    //}


    switch (valorEntrada)
    {
        case "1":
            baraja1.Barajar();
            break;
        case "2":
            Console.Write("La carta elegida es: ");
            Console.WriteLine(baraja1.SiguienteCarta());
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            Console.WriteLine(baraja1.CartasDisponibles());
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("-----------------------------Dar cartas-------------------------------------"); 
            Console.WriteLine("============================================================================");
            Console.WriteLine("Ingrese la cantidad de cartas que desea obtener");
            int cantidad = int.Parse(Console.ReadLine());
            baraja1.DarCartas(cantidad);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey(); 
            Console.Clear();
            break;
        case "5":
            baraja1.CartasMonton();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;
        case "6":
            baraja1.MostrarBaraja();
            Console.Clear();
            break;

        case "7":
            Console.WriteLine("Muchas Gracias por usar nuestra aplicacion");
            System.Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opcion no valida, favor de ingresar una opcion correcta");
            Console.WriteLine("Retornando al menu principal...");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            break;
    }


} while (valorEntrada!="0");

