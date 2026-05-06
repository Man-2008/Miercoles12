using System;

namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Ventas = new int[5, 7];
            int Contador = 0;
            int SumaVentasSemana = 0;
            int Promedio;
            int PromedioDia;

            Console.WriteLine("Holii soy Mochi, te voy a ayudar a terminar las cuentas rapidito :D...");
            Console.WriteLine("A continuacion ingresa los datos de cada almacen siguiendo las instrucciones.");

            for (int i = 0; i < Ventas.GetLength(0); i++)
            {
                for (int j = 0; j < Ventas.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa los datos del almacen:{i + 1} , en el dia: {j + 1}.");
                    Ventas[i, j] = int.Parse(Console.ReadLine());

                    if (Ventas[i, j] < 0)
                    {
                        while (Ventas[i,j]  < 0)
                        {
                            Console.WriteLine("Huy, los valores ingresados son menores a 0, porfavor verifica los datos, quiza fue un error, o comunicale a tu superior el estado de deuda :)...");
                            Console.WriteLine(Ventas[i, j]);
                            Console.WriteLine($"Ingresa los datos del almacen:{i} , en el dia: {j}.");
                            Ventas[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    else if (Ventas[i,j] == 0)
                    {
                        Console.WriteLine($"Uf, ojo con esas ventas: {Ventas[i, j]}, no sea que te regañen");
                    }
                    else
                    {
                        Console.WriteLine($"Todo bien el total del dia fue: {Ventas[i, j]}");
                    }
                }
            }

            Console.WriteLine("Hey mira, ya terminaste de llenar las ventas de esta semana en cada almacen, ¡¡felicidades!! mira tu resultado");
            for (int i = 0; i < Ventas.GetLength(0); i++)
            {
                for (int j = 0; j < Ventas.GetLength(1); j++)
                {
                    Console.Write($"| {Ventas[i, j]} | ");

                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Ya hiciste tu trabajo, ahora me toca a mi: ");

            for (int i = 0; i < Ventas.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    while (Contador < 8)
                    {
                        SumaVentasSemana = Ventas[i, j] + Ventas[i + 1, j + 1];
                        Contador++;
                    }

                    PromedioDia = SumaVentasSemana / 7;
                    Console.WriteLine($"Promedio Ventas por dia {i + 1} : {PromedioDia} ");
                    Console.WriteLine(" ");
                }
                Promedio = SumaVentasSemana / 7;
                Console.WriteLine($"Promedio Almacen {i + 1} : {Promedio} ");
                Console.WriteLine(" ");
            }
            
        }
    }
}
