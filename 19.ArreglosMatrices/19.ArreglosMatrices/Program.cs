using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
namespace _19.ArreglosMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] Numeros = new int[2, 3]; //[,] indica que es un arreglo bidimensional
            string[,] Nombres = new string[2, 2]; //[2,2] indica que es un arreglo bidimensional de 2 filas y 2 columnas
            string[,] Nombres2 =
            {
                { "Juan", "Maria" },
                {  "Pedro", "Ana"   },
                {"Alvaro", "Luis" }
            };

            Numeros[0, 0] = 1; // Asignamos el valor 1 a la posición [0,0] del arreglo Numeros
            Numeros[0, 1] = 2; // Asignamos el valor 2 a la posición [0,1] del arreglo Numeros
            Numeros[0, 2] = 3;
            Numeros[1, 0] = 5;
            Numeros[1, 1] = 6;
            Numeros[1, 2] = 7;

            //recorrer la matriz para llenarla

            char[,] Letras = new char[2, 3];
            for (int i = 0; i < 2; i++) //recorremos las filas del arreglo Letras
            {
                for (int j = 0; j < 3; j++)//recorremos las columnas del arreglo Letras
                {
                    Console.WriteLine($"Ingrese la letra para la posición [{i},{j}]: ");
                    Letras[i, j] = Console.ReadLine()[0]; // Leemos una letra y la asignamos a la posición [i,j] del arreglo Letras
                }
            }

            //imprimir el arreglo Letras

            Console.WriteLine("El arreglo Letras es: ");
            for (int i = 0; i < Letras.GetLength(0); i++) //GetLength(0) devuelve el número de filas del arreglo Letras
            {
                for (int j = 0; j < Letras.GetLength(1); j++)//GetLength(1) devuelve el número de columnas del arreglo Letras
                {
                    Console.Write(Letras[i, j] + " "); // Imprimimos la letra en la posición [i,j] del arreglo Letras seguida de un espacio
                }
                Console.WriteLine(); // Imprimimos una nueva línea después de cada fila
            }*/


            /*Escriba un programa que realize la suma de dos matrices de dimensiones 2*3.
              * Requisitos del programa
                Escribe un programa que realice la suma de dos matrices de dimensiones 2*3
                Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas
                Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3)
                Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices
                Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).

            int[,] Matriz1 = new int[2, 3];
            int[,] Matriz2 = new int[2, 3];
            int [,] Suma = new int[2, 3];

            for (int i = 0;i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el elemento para la posición [{i},{j}] de la Matriz 1: ");
                    Matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el elemento para la posición [{i},{j}] de la Matriz 2: ");
                    Matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Suma[i, j] = Matriz1[i, j] + Matriz2[i, j];
                }
            }
            Console.WriteLine("La matriz resultante de la suma es: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Suma[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            /*Desarrolla un algoritno que realice las siquientes tarens
            Capturar los nombres de cuatro empleados ingresados por teclado
            Para cada empleado, capturar los sueldos recibidos durante los ultimos 3 meses
            calcular y mostrar el total acumulado de sueldos que ha recibido cada empleado en ese periodo
            (identificar y mostrar el nombre del empleado con el mayor sueldo acumulado junto con el total que recibio.*/

            string[] Empleados = new string[4];
            double[,] Sueldos = new double[4, 3];
            double[,] TotalSueldos = new double[4, 1];

            for (int i = 0; i < Empleados.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre del empleado {i + 1}: ");
                Empleados[i] = Console.ReadLine();
                for (int j = 0; j < Sueldos.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el sueldo del mes {j + 1} para el empleado {Empleados[i]}: ");
                    Sueldos[i, j] = double.Parse(Console.ReadLine());
                    TotalSueldos[i, 0] += Sueldos[i, j];
                }
            }
            

        }
    }
}
