using System;

namespace RPC
{
    class RPC
    {
        static void Main(string[] args)
        {
        Titulo:
            //Esta etiqueta me va a servir para que cuando pierdas el juego no se cierre, si no que vengas aqui
            Console.Title = "RPC V0.2";
            Console.WindowHeight = 45;
            Console.WindowWidth = 160;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("RRRRRRRRRRRRRRRRR   PPPPPPPPPPPPPPPPP           CCCCCCCCCCCCC");
            Console.WriteLine("R::::::::::::::::R  P::::::::::::::::P       CCC::::::::::::C");
            Console.WriteLine("R::::::RRRRRR:::::R P::::::PPPPPP:::::P    CC:::::::::::::::C");
            Console.WriteLine("RR:::::R     R:::::RPP:::::P     P:::::P  C:::::CCCCCCCC::::C");
            Console.WriteLine("  R::::R     R:::::R  P::::P     P:::::P C:::::C       CCCCCC");
            Console.WriteLine("  R::::R     R:::::R  P::::P     P:::::PC:::::C              ");
            Console.WriteLine("  R::::RRRRRR:::::R   P::::PPPPPP:::::P C:::::C              ");
            Console.WriteLine("  R:::::::::::::RR    P:::::::::::::PP  C:::::C              ");
            Console.WriteLine("  R::::RRRRRR:::::R   P::::PPPPPPPPP    C:::::C              ");
            Console.WriteLine("  R::::R     R:::::R  P::::P            C:::::C              ");
            Console.WriteLine("  R::::R     R:::::R  P::::P            C:::::C              ");
            Console.WriteLine("  R::::R     R:::::R  P::::P             C:::::C       CCCCCC");
            Console.WriteLine("RR:::::R     R:::::RPP::::::PP            C:::::CCCCCCCC::::C");
            Console.WriteLine("R::::::R     R:::::RP::::::::P             CC:::::::::::::::C");
            Console.WriteLine("R::::::R     R:::::RP::::::::P               CCC::::::::::::C");
            Console.WriteLine("RRRRRRRR     RRRRRRRPPPPPPPPPP                  CCCCCCCCCCCCC");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Role Play... ¿Console?\n\n\n");
            Console.WriteLine("¿Que quieres hacer?");
            Console.WriteLine("\ta - Nueva partida");
            Console.WriteLine("\tb - Creditos");
            Console.WriteLine("\tc - Salir");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.Clear();
                    goto Jugar;
                    break;
                case "b":
                    Console.Clear();
                    goto Creditos;
                    break;
                case "c":
                    goto Cerrar;
                    break;
                default:
                    Console.Clear();
                    goto Titulo;
                    break;

            }
        Creditos:
            Console.WriteLine("No Disponible por el momento");
            Console.ReadKey();
            Console.Clear();
            goto Titulo;
        Jugar:
            int VidaPersonaje; int FuerzaPersonaje; int DefensaPersonaje; int VelocidadPersonaje; string ClasePersonaje = "Null";
            Console.WriteLine("Nombre del personaje:");
            string NombrePersonaje = Console.ReadLine();
            Console.WriteLine("¿Y que de que clase es " + NombrePersonaje + "?\n\ta - Mago\n\tb - Caballero\n\tc - Cazador\n\td - Luchador");
            switch (Console.ReadLine())
            {
                case "a":
                    VidaPersonaje = 50; FuerzaPersonaje = 75; DefensaPersonaje = 25; VelocidadPersonaje = 50;
                    ClasePersonaje = "Mago";
                    break;
                case "b":
                    VidaPersonaje = 50; FuerzaPersonaje = 25; DefensaPersonaje = 75; VelocidadPersonaje = 50;
                    ClasePersonaje = "Caballero";
                    break;
                case "c":
                    VidaPersonaje = 25; FuerzaPersonaje = 50; DefensaPersonaje = 50; VelocidadPersonaje = 75;
                    ClasePersonaje = "Cazador";
                    break;
                case "d":
                    VidaPersonaje = 75; FuerzaPersonaje = 50; DefensaPersonaje = 50; VelocidadPersonaje = 25;
                    ClasePersonaje = "Luchador";
                    break;
                default:
                    Console.Clear();
                    goto Jugar;
                    break;
            }
            int RNumero = RandomNumber(1, 1001);
            Console.Clear();
            Console.WriteLine(NombrePersonaje + "el" + ClasePersonaje + " entra en la mazmorra buscando el tesoro que le aguarda en lo mas profundo.");
            Console.ReadKey();


        Combate:
            int VidaEnemigo; int AtaqueEnemigo; int VelocidadEnemigo; int DefensaEnemigo;
            for (int i = 1; i < 51; i++)
            {
                //Si el piso es multiplo de 5 entonces te encontraras una sala especial, tienda, cofre, sala trampa... Seguramente tenga que hacer el sistema de inventario prime
                if (i % 5 == 0 && i != 50)
                {
                    Console.WriteLine("Piso: " + i + "\n\n\n");
                    Console.WriteLine("Algo especial todavia sin decidir");
                }
                //Pelea de jefe, tras esta se acaba el juego 
                else if (i == 50)
                {
                    Console.WriteLine("Llegas al final de la mazmorra y encuentras (x) jajajajaj todavia no se que va a ser el jefe");
                    Console.WriteLine("Piso: " + i + "\n\n\n");
                }
                else
                {
                    Console.WriteLine("Piso: " + i + "\n\n\n");
                    Console.WriteLine("¿Que quieres hacer?");
                    Console.WriteLine("\n\ta - Luchar\n\tb - Caballero\n\tc - Cazador\n\td - Luchador");
                }
            }



        Cerrar:;

        }

        //Función para crear todo el RNG del programa, lo llamo cada vez que una decision de suerte y porcentajes es necesaria
        static int RandomNumber(int MinRNumero, int MaxRNumero)
        {
            Random RNumero = new Random();
            int NumeroRandom = RNumero.Next(MinRNumero, MaxRNumero);
            return NumeroRandom;
        }
    }
}