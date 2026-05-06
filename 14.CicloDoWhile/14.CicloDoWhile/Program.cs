using System;
using System.Security.Policy;

namespace _14.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el número 100. 

            int numero = 1;
            int contadorDivisores = 0;
            int cantidadNumerosPrimos = 0;
            int contadorNumeros = 1;

            do
            {
                contadorDivisores = 0;
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        contadorDivisores++;
                    }
                }
                if (contadorDivisores == 2)
                {
                    Console.WriteLine(numero);
                    cantidadNumerosPrimos++;
                }
                contadorNumeros++;
                numero++;
            } while (contadorNumeros <= 100);*/


            /* Escriba un algoritmo que actue como una calculadora basica. El algoritmo le debe permitir al usuario elegir una operacion (suma, resta, multiplicacion, division), y luego ingresar dos numeros. El ciclo debe continuar hasta que elija salir.


            string operacion = " ";
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Bienvenido a la calculadora basica. Elija una operacion: suma, resta, multiplicacion, division o salir.");
            operacion = Console.ReadLine();

            if (operacion == "salir")
            {
                Console.WriteLine("Gracias por usar la calculadora. Hasta luego!");
            }
            else
            {
                do
                {

                    Console.WriteLine("Ingrese el primer numero:");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero:");
                    numero2 = int.Parse(Console.ReadLine());
                    switch (operacion)
                    {
                        case "suma":
                            Console.WriteLine("El resultado de la suma es: " + (numero1 + numero2));
                            break;
                        case "resta":
                            Console.WriteLine("El resultado de la resta es: " + (numero1 - numero2));
                            break;
                        case "multiplicacion":
                            Console.WriteLine("El resultado de la multiplicacion es: " + (numero1 * numero2));
                            break;
                        case "division":
                            if (numero2 != 0)
                            {
                                Console.WriteLine("El resultado de la division es: " + (numero1 / numero2));
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir por cero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Operacion no valida.");
                            break;
                    }
                    Console.WriteLine("Elija una operacion: suma, resta, multiplicacion, division o salir.");
                    operacion = Console.ReadLine();

                } while (operacion != "salir");
            }*/


            /*Crear un algoritmo que permita ingresar numeros:
             * contar cuantos son pares y cuantos son impares
             * calcular el promedio de todos los numeros ingreados
             * Terminar cuando el usuario lo indique.

            int numero = 0;
            int cantidadPares = 0;
            int cantidadImpares = 0;
            int sumaNumeros = 0;
            int cantidadNumeros = 0;
            string continuar;
            int promedio = 0;

            Console.WriteLine("Bienvenido. Ingrese numeros para contar cuantos son pares e impares, y calcular el promedio. Escriba 'salir' para terminar.");
            numero = int.Parse(Console.ReadLine());

            do
            {
                if (numero % 2 == 0)
                {
                    cantidadPares++;
                }
                else
                {
                    cantidadImpares++;
                }
                sumaNumeros += numero;
                cantidadNumeros++;
                Console.WriteLine("Ingrese otro numero o escriba 'salir' para terminar:");
                continuar = Console.ReadLine();

            }while (continuar != "salir");
            
            if (cantidadNumeros > 0)
            {
                promedio = sumaNumeros / cantidadNumeros;
                Console.WriteLine("Cantidad de numeros pares: " + cantidadPares);
                Console.WriteLine("Cantidad de numeros impares: " + cantidadImpares);
                Console.WriteLine("Promedio de los numeros ingresados: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros.");
            }*/


            /* Crear un algoritmo que:
             * permita al usuario ingresar una contraseña
             * Se repita hasta que ingrese la contraseña correcta
             * Mostrar cuantos intentos se realizaron*/

            string contraseña = "contraseña123";
            string contraseñaIngresada = " ";
            int intentos = 0;

            Console.WriteLine("Bienvenido. Ingrese la contraseña para acceder al sistema:");
            contraseñaIngresada = Console.ReadLine();

            do
            {
                if (contraseñaIngresada != contraseña)
                {
                    intentos++;
                    Console.WriteLine("Contraseña incorrecta. Intente nuevamente:");
                    contraseñaIngresada = Console.ReadLine();
                }
            }while(contraseñaIngresada != contraseña);
            intentos++;
            Console.WriteLine("Contraseña correcta. Intentos realizados: " + intentos);
        }
    }
}
