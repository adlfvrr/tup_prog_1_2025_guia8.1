using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4.Models
{
    internal class Servicio
    {
        private string jugador1, jugador2;
        private int setGanados1, setGanados2;
    public Servicio()
        {
            jugador1 = ""; jugador2 = ""; setGanados1 = 0; setGanados2 = 0;
        }
        public void RegistrarJugadores()
        {
            if (jugador1 == "")
            {
                Console.Write("Ingrese nombre de jugador 1: ");
                jugador1 = Console.ReadLine();
            }
            else if (jugador2 == "")
            {
                Console.Write("Ingrese nombre de jugador 2: ");
                jugador2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Jugadores ya registrados.");
                Console.ReadKey();
            }

        }
        public void RegistrarResultadoSet()
        {
            int j1, j2;
            if (jugador1 == "" || jugador2 == "")
            {
                Console.WriteLine("Registrar jugadores primero.");
                Console.ReadKey();
            }
            else
            {
                if (setGanados1 == 0 && setGanados2 == 0)
                {
                    Console.Write("Ingrese juego del jugador 1: ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese juego del jugador 2: ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    if (j1 >= 4)
                    {
                        if (j1 >= j2 + 2)
                        {
                            Console.WriteLine($"Ganador del set: {jugador1}");
                            setGanados1 = 1;
                        }
                        else
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                setGanados2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            }
                        }
                    }
                    else
                    {
                        if (j2 >= 4)
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                setGanados2 = 1;
                            }
                            else
                            {
                                if (j1 >= j2 + 2)
                                {
                                    Console.WriteLine($"Ganador del set: {jugador1}");
                                    setGanados1 = 1;
                                }
                                else
                                {
                                    Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("La puntuación mínima necesaria para ganar un set es de 4 puntos");
                        }
                    }
                }
                else if (setGanados1 == 1 || setGanados2 == 1)
                {
                    Console.WriteLine("Ingrese juego del jugador 1: ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese juego del jugador 2: ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    if (j1 >= 4)
                    {
                        if (j1 >= j2 + 2)
                        {
                            Console.WriteLine($"Ganador del set: {jugador1}");
                            if (setGanados1 == 1)
                            {
                                setGanados1++;
                            }
                            else
                            {
                                setGanados1 = 1;
                            }
                        }
                        else
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                if (setGanados2 == 1)
                                {
                                    setGanados2++;
                                }
                                else
                                {
                                    setGanados2 = 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            }
                        }
                    }
                    else
                    {
                        if (j2 >= 4)
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {jugador2}");
                                if (setGanados2 == 1)
                                {
                                    setGanados2++;
                                }
                                else
                                {
                                    setGanados2 = 1;
                                }
                            }
                            else
                            {
                                if (j1 >= j2 + 2)
                                {
                                    Console.WriteLine($"Ganador del set: {jugador1}");
                                    if (setGanados1 == 1)
                                    {
                                        setGanados1++;
                                    }
                                    else
                                    {
                                        setGanados1 = 1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La puntuación mínima necesaria para ganar un set es de 4 puntos.");
                        }
                    }
                }
                else if (setGanados1 == 1 && setGanados2 == 1)
                {
                    Console.WriteLine("Ingrese juego del jugador 1: ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese juego del jugador 2: ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    if (j1 >= 4)
                    {
                        if (j1 >= j2 + 2)
                        {
                            setGanados1++;
                        }
                        else
                        {
                            if (j2 >= j1 + 2)
                            {
                                setGanados2++;
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            }
                        }
                    }
                    else
                    {
                        if (j2 >= 4)
                        {
                            if (j2 >= j1 + 2)
                            {
                                setGanados2++;
                            }
                            else
                            {
                                if (j1 >= j2 + 2)
                                {
                                    setGanados1++;
                                }
                                else
                                {
                                    Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La puntuación minima necesaria para ganar un set es de 4 puntos.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se pueden procesar más juegos.");
                }
            }
        }
        public string DeterminarGanador()
        {
            string ganador = "";
            if (setGanados1 == 2)
            {
                ganador = jugador1;
            }
            else if (setGanados2 == 2)
            {
                ganador = jugador2;
            }
            else
            {
                Console.WriteLine("Se deben procesar más juegos.");
                Console.ReadKey();
            }
            return ganador;
        }
    }
}
