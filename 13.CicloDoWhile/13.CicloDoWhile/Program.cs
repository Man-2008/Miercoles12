using System;

namespace _13.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int sumaEnteros = 0; //Acumulador

            do
            {
                sumaEnteros += contador;
                contador ++;

            } while (contador < 6);

            Console.WriteLine("La suma de los enteros del 1 al 5 es: " + sumaEnteros);

            /* Algoritmo que solicita un numero y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. */

            int numero = 0;
            char respuesta = ' ';
            int Contador = 1;

            

            do
            {
                Console.Clear();
                Console.WriteLine("Digite un numero para generar su tabla de multiplicar: ");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} x {Contador} = {numero * Contador}");
                    Contador++;
                } while (Contador <= 10);

                Console.WriteLine("Desea generar otra tabla de multiplicar? (S/N)");
                respuesta = char.Parse(Console.ReadLine());
                
                Contador = 1; //Reiniciamos el contador para la siguiente tabla de multiplicar

            } while (respuesta == 'S');


            /*Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente:

Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito”
Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito”
El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más.

Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.*/


            string nombre = "";
            int numeroCuenta = 0;
            int saldo = 0;
            int contadorUsuarios = 0;
            string continuar = " ";
            int sumaSaldos = 0;
            int promedioSaldos = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite el nombre del usuario: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite el numero de cuenta del usuario: ");
                numeroCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el saldo del usuario: ");
                saldo = int.Parse(Console.ReadLine());

                if (saldo > 3000000)
                {
                    Console.WriteLine($"{nombre}, con numero de cuenta {numeroCuenta} y saldo de {saldo} es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"{nombre}, con numero de cuenta {numeroCuenta} y saldo de {saldo} no es apto para el crédito");
                }

                contadorUsuarios++;
                sumaSaldos += saldo;
                Console.WriteLine("Desea ingresar la información de otro usuario? (Si/No)");
                continuar = Console.ReadLine();

            } while (continuar == "Si");

            Console.WriteLine("El numero de usuarios ingresados es: " + contadorUsuarios);
            Console.WriteLine("El promedio de los saldos es: " + (sumaSaldos / contadorUsuarios) );


        }
    }
}
