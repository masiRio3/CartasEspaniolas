
namespace CartasEspaniolas.Modelos
{
    public class Baraja: Carta
    {

        public Baraja()
        {
            Cartas = new List<Carta>();

            for (int numero = 1; numero <= 12; numero++)
            {
                var c = new Carta(numero, "Espada");
                Cartas.Add(c);
                if (c.Numero==8|| c.Numero==9)
                {
                    Cartas.Remove(c);
                }

            }

            for (int numero = 1; numero <= 12; numero++)
            {
                var c = new Carta(numero, "Basto");
                Cartas.Add(c);
                if (c.Numero == 8 || c.Numero == 9)
                {
                    Cartas.Remove(c);
                }
            }
        
            for (int numero = 1; numero <= 12; numero++)
            {
                var c = new Carta(numero, "Oro");
                Cartas.Add(c);
                if (c.Numero == 8 || c.Numero == 9)
                {
                    Cartas.Remove(c);
                }
            }
            for (int numero = 1; numero <= 12; numero++)
            {
                var c = new Carta(numero, "Copa");
                Cartas.Add(c);
                if (c.Numero == 8 || c.Numero == 9)
                {
                    Cartas.Remove(c);
                }
            }
        }

        public List<Carta> Cartas { get; set; }
        public List<Carta> MasoBarajado { get; set; }
        public List<Carta> CartasRepartidas { get; set; }


        public void Barajar()
        {
            MasoBarajado = new List<Carta>();
            CartasRepartidas = new List<Carta>();


            Random aleatorio = new Random();

            for (int i = 0; i < Cartas.Count; i++)
            {
                Carta carta = Cartas[i];
                MasoBarajado.Insert(aleatorio.Next(MasoBarajado.Count), carta);
            }

            Console.WriteLine("Desea ver el maso barajado s/n ");
            string opcion = Console.ReadLine();


            do
            {
                switch (opcion.ToUpper())
                {
                    case "S":
                        foreach (var c in MasoBarajado)
                        {    
                            
                            Console.WriteLine(c.Numero + " de " + c.Palo);
                          
                        }
                        Console.WriteLine("Presione cualquier tecla para retonar al menu principal");
                        Console.ReadKey();
                        Console.WriteLine("Retornando al menu principal");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        opcion = "0";
                            
                        break;
                        
                        
                    case "N":
                        Console.WriteLine("No se muestra el maso");
                        Console.WriteLine("Retornando al menu principal");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();  
                        opcion = "0";
                        break;

                    default:
                        Console.WriteLine("Opcion no valida, favor de ingresar una opcion correcta");
                        opcion = Console.ReadLine();
                        break;

                }


            } while (opcion!="0");




        }

        public void BarajarBack()
        {
            MasoBarajado = new List<Carta>();
            CartasRepartidas = new List<Carta>();


            Random aleatorio = new Random();

            for (int i = 0; i < Cartas.Count; i++)
            {
                Carta carta = Cartas[i];
                MasoBarajado.Insert(aleatorio.Next(MasoBarajado.Count), carta);
            }


        }


        public void DarCartas(int cantidad)
        {
            if (MasoBarajado == null)
            {
                BarajarBack();
            }

            Console.WriteLine("El maso se está barajando");
            
            System.Threading.Thread.Sleep(1000);
            Console.Write("*");
            System.Threading.Thread.Sleep(1000);
            Console.Write("*");
            System.Threading.Thread.Sleep(1000);
            Console.Write("*");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            BarajarBack();
            

            if (cantidad <= MasoBarajado.Count)
            {
                for (int i = 0; i <= cantidad; i++)
                {
                    Carta cartaASalir = MasoBarajado[i];
                    MasoBarajado.Remove(cartaASalir);
                    Cartas.Remove(cartaASalir);
                    CartasRepartidas.Add(cartaASalir);
                    Console.WriteLine($"{cartaASalir.Numero} de {cartaASalir.Palo}");
                }
            }

            else
            {
                Console.WriteLine("No hay suficientes cartas");
            }


        }

        public string SiguienteCarta()
        {
            if (MasoBarajado==null)
            {
                BarajarBack();
            }


                int posicion = 0;
                Carta cartaSiguiente = MasoBarajado[posicion];
                MasoBarajado.Remove(cartaSiguiente);
                Cartas.Remove(cartaSiguiente);
                CartasRepartidas.Add(cartaSiguiente);
                posicion++;
                


                if (posicion <= MasoBarajado.Count)
                {
                    return ($"{cartaSiguiente.Numero} de {cartaSiguiente.Palo}");

                }
                else
                {
                    return ("No hay mas cartas disponibles en el maso");
                }

        }


        public void CartasMonton()
        {
            if (MasoBarajado == null)
            {
                BarajarBack();
            }
            

                if (CartasRepartidas.Count == 0)
                {
                    Console.WriteLine("No se han repartido cartas aun");
                }
                else
                {
                    Console.WriteLine("Cartas del monton");
                    foreach (var item in CartasRepartidas)
                    {
                        Console.WriteLine($"{item.Numero} de {item.Palo}");
                    }
                }
            
         
      
           
        }
        

        public string CartasDisponibles()
        {
            if (MasoBarajado == null)
            {
                BarajarBack();
            }

            

            return ($"Quedan {MasoBarajado.Count} cartas disponibles");
       
        }


        public void MostrarBaraja()
        {
            Console.WriteLine("*********************************************************");


            foreach (var item in Cartas)
            {

                Console.WriteLine($"{item.Numero} de {item.Palo}");

                if (item.Numero == 12) 
                {
                    Console.WriteLine("*********************************************************");
                }

            }

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }




    }



}
