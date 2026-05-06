using System;


namespace _16.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   

El número de partidos perdidos 
El número de partidos empatados 
El número de partidos ganados 
El porcentaje de partidos perdidos 
El porcentaje de partidos empatados 
El porcentaje de partidos ganados*/

            int partidosPerdidos = 0;
            int partidosEmpatados = 0;
            int partidosGanados = 0;
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"Ingrese el resultado del partido {i} (P: Perdido, E: Empatado, G: Ganado):");
                string resultado = Console.ReadLine().ToUpper();
                switch (resultado)
                {
                    case "P":
                        partidosPerdidos++;
                        break;
                    case "E":
                        partidosEmpatados++;
                        break;
                    case "G":
                        partidosGanados++;
                        break;
                    default:
                        Console.WriteLine("Resultado inválido. Por favor ingrese P, E o G.");
                        i--; // Repetir el mismo partido
                        break;
                }
            }
            Console.WriteLine($"\nNúmero de partidos perdidos: {partidosPerdidos}");
            Console.WriteLine($"Número de partidos empatados: {partidosEmpatados}");
            Console.WriteLine($"Número de partidos ganados: {partidosGanados}");
            double porcentajePerdidos = (double)partidosPerdidos / 30 * 100;
            double porcentajeEmpatados = (double)partidosEmpatados / 30 * 100;
            double porcentajeGanados = (double)partidosGanados / 30 * 100;
            Console.WriteLine($"\nPorcentaje de partidos perdidos: {porcentajePerdidos:F2}%");
            Console.WriteLine($"Porcentaje de partidos empatados: {porcentajeEmpatados:F2}%");
            Console.WriteLine($"Porcentaje de partidos ganados: {porcentajeGanados:F2}%");


        }
    }
}
