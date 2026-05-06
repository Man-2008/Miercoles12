using System;
using System.Runtime.ConstrainedExecution;


namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar el nonbre y el sueldo de una persona, si el sueldo supera los 3088 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonan impuestos.//

            /*string nombre = "";
            float sueldo = 0.0f;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del usuario");
            sueldo = Convert.ToSingle (Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine($"El usuario {nombre} debe pagar impuestos");
            }*/

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 se debe mostrar el siguiente mensaje:."Bienvenido a mi sitio web".*/
            
            float edad = 0.0f;
            Console.WriteLine("Ingrese la edad del usuario");
            edad = Convert.ToSingle(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine($"Bienvenido a mi sitio web");
            }

        }
    }
}
