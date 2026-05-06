using System;
using System.Runtime.ConstrainedExecution;

namespace _3.CondicionalIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el suelos supera los 3000 pesos mostrar el mensaje en pantalla con el nonbre de la persona, Indicando que debe abonar impuestos. De lo contrario mostrar el mensaje "Persona exenta de impuestos//

            string nombre = "";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor del sueldo");
            sueldo = Single.Parse(Console.ReadLine());

            if(sueldo >= 3000)
            {
                Console.WriteLine($"La persona {nombre} debe abonar impuestos");
            }
            else
            {
                Console.WriteLine($"La persona {nombre} esta exenta de impuestos");
            }

            //Crear un algoritno que permita ingresar dos núneros, si el priner núnars us meyer al segundo número informar su suna y diferencia, en caso contrario informar el producte La división del primer número respecto al segundo número.//

            float numero1 = 0;
            float numero2 = 0;
            float suma = 0;
            float resta = 0;
            float multiplicacion = 0;
            float division = 0;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Single.Parse(Console.ReadLine());

            if (numero1 >= numero2)
            {
                suma = numero1 + numero2;
                resta = numero1 + numero2;
                Console.WriteLine($"El numero {numero1} es mayor al numero {numero2}, por lo tanto la suma del numero {numero1} con el numero {numero2} es: {suma}, y la resta de los mismos numeros es: {resta}");
            }
            else
            {
                multiplicacion = numero1 * numero2;
                division = numero1 / numero2;
                Console.WriteLine($"El numero {numero1} es menor al numero {numero2}, por lo tanto la multiplicacion del numero {numero1} con el numero {numero2} es: {multiplicacion}, y la division de los mismos numeros es: {division}");
            }



        }
    }
}
