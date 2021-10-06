using System;

namespace RPC
{
    class RPC
    {
        static void Main(string[] args)
        {
        Titulo:
            //Esta etiqueta me va a servir para que cuando pierdas el juego no se cierre, si no que vengas aqui
            Console.Title = "RPC V0.5";
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
            Console.WriteLine("Hecho por Jandriv");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("Eso es todo");
            System.Threading.Thread.Sleep(1400);
            Console.Clear();
            goto Titulo;
        Jugar:
            int VidaPersonaje; int AtaquePersonaje; int DefensaPersonaje; int VelocidadPersonaje; string ClasePersonaje = "Null";
            Console.WriteLine("Nombre del personaje:");
            string NombrePersonaje = Console.ReadLine();
            Console.WriteLine("¿Y que de que clase es " + NombrePersonaje + "?\n\ta - Mago\n\tb - Caballero\n\tc - Cazador\n\td - Luchador");
            switch (Console.ReadLine())
            {
                case "a":
                    VidaPersonaje = 50; AtaquePersonaje = 75; DefensaPersonaje = 25; VelocidadPersonaje = 20;
                    ClasePersonaje = "Mago";
                    break;

                case "b":
                    VidaPersonaje = 50; AtaquePersonaje = 25; DefensaPersonaje = 75; VelocidadPersonaje = 20;
                    ClasePersonaje = "Caballero";
                    break;

                case "c":
                    VidaPersonaje = 25; AtaquePersonaje = 50; DefensaPersonaje = 50; VelocidadPersonaje = 40;
                    ClasePersonaje = "Cazador";
                    break;

                case "d":
                    VidaPersonaje = 75; AtaquePersonaje = 50; DefensaPersonaje = 50; VelocidadPersonaje = 10;
                    ClasePersonaje = "Luchador";
                    break;

                case "debug":
                    VidaPersonaje = 750; AtaquePersonaje = 500; DefensaPersonaje = 500; VelocidadPersonaje = 100;
                    ClasePersonaje = "Made in heaven";
                    break;

                default:
                    Console.Clear();
                    goto Jugar;
                    break;
            }
            int RNumero = RandomNumber(1, 1001);
            Console.Clear();
            Console.WriteLine(NombrePersonaje + " el " + ClasePersonaje + " entra en la mazmorra buscando el tesoro que le aguarda en lo mas profundo.\n\n");
            System.Threading.Thread.Sleep(2200);


        Combate:
            int VidaEnemigo; int AtaqueEnemigo; int VelocidadEnemigo; int DefensaEnemigo;
            int VidaMinEnemigo; int AtaqueMinEnemigo; int VelocidadMinEnemigo;int DefensaMinEnemigo;
            int VidaMaxEnemigo; int AtaqueMaxEnemigo; int VelocidadMaxEnemigo; int DefensaMaxEnemigo;
            bool EnemigoRecarga; int Daño; int Vida;
            for (int i = 1; i < 51; i++)
            {
                //Si el piso es multiplo de 5 entonces te encontraras una sala especial, tienda, cofre, sala trampa... Seguramente tenga que hacer el sistema de inventario primero
                if (i % 5 == 0 && i != 50)
                {
                    Console.WriteLine("Piso: " + i + "\n\n\n");
                    Console.WriteLine("Algo especial todavia sin decidir");
                    goto FinDelPiso;
                }
                //Pelea de jefe, tras esta se acaba el juego 
                else if (i == 50)
                {
                    VidaEnemigo = 0;
                    AtaqueEnemigo = 0;
                    VelocidadEnemigo = 0;
                    DefensaEnemigo = 0;
                    Console.WriteLine("Llegas al final de la mazmorra y encuentras (x) jajajajaj todavia no se que va a ser el jefe");
                    
                }
                //Pelea default, estadisticas aumentan con cada piso
                else
                {
                    VidaMinEnemigo = (50 + (i * 4)); VidaMaxEnemigo = (80 + (i * 4));
                    AtaqueMinEnemigo = (20 + (i * 2)); AtaqueMaxEnemigo = (40 + (i * 2));
                    VelocidadMinEnemigo = (1 + (i/2)); VelocidadMaxEnemigo = (3 + (i/2));
                    DefensaMinEnemigo = (5 + (i)); DefensaMaxEnemigo = (10 + (i));

                    VidaEnemigo = RandomNumber(VidaMinEnemigo, VidaMaxEnemigo);
                    AtaqueEnemigo = RandomNumber(AtaqueMinEnemigo, AtaqueMaxEnemigo);
                    VelocidadEnemigo = RandomNumber(VelocidadMinEnemigo, VelocidadMaxEnemigo);
                    DefensaEnemigo = RandomNumber(DefensaMinEnemigo, DefensaMaxEnemigo);
                }
                while (VidaEnemigo > 0 && VidaPersonaje > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Piso: " + i + "\n\n\n");
                    Console.WriteLine("¿Que quieres hacer?");
                    Console.WriteLine("\n\ta - Luchar\n\tb - Bloquear\n\tc - Estadísticas\n\td - Inventario\n\te - Huir");
                    switch (Console.ReadLine())
                    {
                        case "a":
                            Console.WriteLine(NombrePersonaje + " atacó al enemigo");
                            System.Threading.Thread.Sleep(1200);
                            if (RandomNumber(1, 101) >= VelocidadEnemigo)
                            {
                                Daño = Convert.ToInt32(AtaquePersonaje * (1 - ((double)DefensaEnemigo / 100)) * (double)RandomNumber(85, 116) / 100);
                                Console.WriteLine("El ataque hizo " + Daño + " puntos de daño");
                                Vida = VidaEnemigo;
                                VidaEnemigo = (Vida - (Daño));
                            }
                            else
                            {
                                Console.WriteLine("¡El enemigo esquivo el ataque!");
                                System.Threading.Thread.Sleep(1200);
                            }
                            if (EnemigoRecarga = false)
                            {
                                System.Threading.Thread.Sleep(1200);
                                Console.WriteLine("¡El enemigo atacó de vuelta!");
                                if (RandomNumber(1, 101) >= VelocidadPersonaje)
                                {
                                    Vida = VidaPersonaje;
                                    Daño = Convert.ToInt32(AtaqueEnemigo * ((1 - (double)(DefensaPersonaje / 100))) * (double)RandomNumber(85, 116) / 100);
                                    VidaPersonaje = (Vida - (Daño));
                                    System.Threading.Thread.Sleep(1200);
                                    Console.WriteLine("El ataque hizo " + Daño + " puntos de daño");
                                }
                                else
                                {
                                    Console.WriteLine("Esquivaste el ataque");
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("El enemigo esta recargando su ataque");
                                EnemigoRecarga = false;
                                Console.ReadKey();
                            }
                            break;

                        case "b":
                            Daño = Convert.ToInt32(AtaqueEnemigo * (1 - ((double)DefensaPersonaje / 100)) * (double)RandomNumber(25, 46) / 100);
                            Vida = VidaPersonaje;
                            VidaPersonaje = (Vida - (Daño));
                            Console.WriteLine("Bloqueaste el ataque y recibiste " + Daño + " puntos de daño");
                            System.Threading.Thread.Sleep(1200);
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("Estadísticas del enemigo ");
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Vida: " + VidaEnemigo);
                            Console.WriteLine("Ataque: " + AtaqueEnemigo);
                            Console.WriteLine("Defensa: " + DefensaEnemigo);
                            Console.WriteLine("Velocidad: " + VelocidadEnemigo);
                            Console.WriteLine("\n\nEstadísticas de " + NombrePersonaje);
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Vida:" + VidaPersonaje);
                            Console.WriteLine("Ataque:" + AtaquePersonaje);
                            Console.WriteLine("Defensa:" + DefensaPersonaje);
                            Console.WriteLine("Velocidad:" + VelocidadPersonaje);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "d":
                            Console.Clear();
                            Console.WriteLine("En progreso");
                            System.Threading.Thread.Sleep(800);
                            Console.Clear();
                            break;

                        case "e":
                            Console.Clear();
                            Console.WriteLine("...");
                            System.Threading.Thread.Sleep(800);
                            Console.WriteLine("...");
                            System.Threading.Thread.Sleep(800);
                            Console.WriteLine("...");
                            System.Threading.Thread.Sleep(800);
                            if (RandomNumber(1, 101) <= (VelocidadPersonaje - VelocidadEnemigo))
                            {
                                Console.WriteLine("Huiste con éxito al siguiente piso");
                                System.Threading.Thread.Sleep(1500);
                                goto FinDelPiso;
                            }
                            else
                            {
                                Console.WriteLine("No conseguiste huir");
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("¡El enemigo atacó!");
                                System.Threading.Thread.Sleep(1000);


                            }
                            break;
                    }
                }
                if (VidaEnemigo <= 0)
                {
                    Console.WriteLine("Enemigo derrotado");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Has muerto");
                    Console.ReadKey();
                    Console.Clear();
                    goto Titulo;
                }

            FinDelPiso:;
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