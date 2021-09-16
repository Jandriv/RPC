using System;

namespace RPC
{
    class Program
    {
        static void Main(string[] args)
        {
        Titulo:
            //Esta etiqueta me va a servir para que cuando pierdas el juego no se cierre, si no que vengas aqui
            Console.Title = "RPC V0.1";
            Console.WindowHeight = 45;
            Console.WindowWidth = 160;
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
                    Console.WriteLine("Opción no válida");
                    break;

            }
        Creditos:
            Console.WriteLine("No Disponible");
            Console.ReadKey();
            Console.Clear();
            goto Titulo;
        Jugar:
            int VidaPersonaje; int FuerzaPersonaje; int DefensaPersonaje; int VelocidadPersonaje;
            Console.WriteLine("Nombre del personaje:");
            string NombrePersonaje = Console.ReadLine();
            Console.WriteLine("¿Y que de que clase es " + NombrePersonaje + "?\n\ta - Mago\n\tb - Caballero\n\tc - Cazador\n\td - Luchador");
            switch (Console.ReadLine())
            {
                case "a":
                    VidaPersonaje = 50; FuerzaPersonaje = 0; DefensaPersonaje = 0; VelocidadPersonaje = 0;
                    break;
                case "b":
                    VidaPersonaje = 50; FuerzaPersonaje = 0; DefensaPersonaje = 0; VelocidadPersonaje = 0;
                    break;
                case "c":
                    VidaPersonaje = 50; FuerzaPersonaje = 0; DefensaPersonaje = 0; VelocidadPersonaje = 0;
                    break;
                case "d":
                    VidaPersonaje = 50; FuerzaPersonaje = 0; DefensaPersonaje = 0; VelocidadPersonaje = 0;
                    break;
            }
            Console.ReadLine();
        Cerrar:;

        }
    }
}