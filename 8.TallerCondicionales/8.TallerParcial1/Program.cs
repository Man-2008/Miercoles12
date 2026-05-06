using System;

namespace _8.TallerParcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes*/

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese el valor del numero1");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero2");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero3");
            numero3 = Int32.Parse(Console.ReadLine());
            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                if (numero1 > numero2)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine($"El numero mayor es: {numero1}");
                        if (numero2 > numero3)
                        {
                            Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero3}, {numero2}, {numero1}");
                        }
                        else
                        {
                            Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero2}, {numero3}, {numero1}");

                        }
                    }
                    else
                    {
                        Console.WriteLine($"El numero mayor es: {numero3}");
                        if (numero1 > numero2)
                        {
                            Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero2}, {numero1}, {numero3}");
                        }
                        else
                        {
                            Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero1}, {numero2}, {numero3}");
                        }

                    }
                }
                else if (numero2 > numero3)
                {
                    Console.WriteLine($"El numero mayor es: {numero2}");
                    if (numero1 > numero3)
                    {
                        Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero3}, {numero1}, {numero2}");
                    }
                    else
                    {
                        Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero1}, {numero3}, {numero2}");
                    }
                }
                else
                {
                    Console.WriteLine($"El numero mayor es: {numero3}");
                    if (numero1 > numero2)
                    {
                        Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero2}, {numero1}, {numero3}");
                    }
                    else
                    {
                        Console.WriteLine($"Los numeros ordenados de menor a mayor son: {numero1}, {numero2}, {numero3}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Debe ingresar 3 numeros diferentes");
            }

            /* 2.El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
                cuenta con munición y si se encuentra en estado invencible, crear un programa que:
                    a. Permita ingresar por teclado si el personaje está en estado invencible (True).
                    b. La cantidad de munición que tiene el personaje en el momento será calculada por el
                       sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.
                       Ejemplo:
                        int numero;
                        Random rnd = new Random();
                        numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
                        Console.WriteLine(numero);
                    c. Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y
                       10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
                       no hacer nada. */

            bool estadoInvencible = false;
            int municion = 0;

            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese el estado del personaje (True/False)");
            estadoInvencible = bool.Parse(Console.ReadLine());

            if (estadoInvencible == true)
            {
                Random rnd = new Random();
                municion = rnd.Next(1, 11);//Devuelve un número entre 0 y 10

                Console.WriteLine($"El personaje está disparando");
                Console.WriteLine($"El personaje tiene {municion} municiones");
            }

            /* 3.Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1),
                 P2(x2,y2), P3(x3,y3). Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
                 P3. La distancia entre dos puntos está dada por la siguiente formula:
                        d = √((x2 - x1)² + (y2 - y1)²)
                 Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
                 dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
                 cumplir para realizar dicha construcción. En caso contrario, decir cuál o cuáles de las
                 condiciones no se cumplen.*/

            float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 0;
            float x3 = 0;
            float y3 = 0;
            float tramoP1P2 = 0;
            float tramoP2P3 = 0;
            float tramoP1P3 = 0;

            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Ingrese las coordenadas del punto P1 (x1,y1)");
            x1 = Single.Parse(Console.ReadLine());
            y1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del punto P2 (x2,y2)");
            x2 = Single.Parse(Console.ReadLine());
            y2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del punto P3 (x3,y3)");
            x3 = Single.Parse(Console.ReadLine());
            y3 = Single.Parse(Console.ReadLine());

            tramoP1P2 = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            tramoP2P3 = (float)Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            tramoP1P3 = (float)Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

            if (tramoP1P2 < tramoP2P3 + tramoP1P3 && tramoP2P3 < tramoP1P2 + tramoP1P3 && tramoP1P3 < tramoP1P2 + tramoP2P3)
            {
                Console.WriteLine("Con las distancias entre los puntos se puede construir un triangulo");
            }
            else
            {
                Console.WriteLine("Con las distancias entre los puntos no se puede construir un triangulo");

            }

            /* 4. El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha),
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
                Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
                derecha
                Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la izquierda
                En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra dirección”*/

            char direccion = ' ';

            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("¿En que direccion me voy a mover? (d/i)");
            direccion = char.Parse(Console.ReadLine());

            if (direccion == 'd')
            {
                Console.WriteLine("Voy hacia la derecha");
            }
            else if (direccion == 'i')
            {
                Console.WriteLine("Voy hacia la izquierda");
            }
            else
            {
                Console.WriteLine("No me puedo mover en otra dirección");
            }

            /*6. El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
                 el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
                    Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje.
                        (Función Random)
                    Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. 
                    En caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar ninguna acción”.
                    Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al carácter que se ingrese:
                        Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
                        Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
                        Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
                        Si se presiona ‘i’, mostrar en consola “el personaje es Invencible” */
            int vidas = 0;
            char accion = ' ';

            Console.WriteLine("Ejercicio 6");
            Random rn = new Random();
            vidas = rn.Next(1, 6);//Devuelve un número entre 0 y 5
            
            if (vidas > 0)
            {
                Console.WriteLine($"Tienes {vidas} vidas, ¿qué accion deseas realizar? (c/x/t/i)");
                accion = char.Parse(Console.ReadLine());

                if (accion == 'c')
                {
                    Console.WriteLine("El personaje está disparando");
                }
                else if (accion == 'x')
                {
                    Console.WriteLine("El personaje está hablando con la Rana");
                }
                else if (accion == 't')
                {
                    Console.WriteLine("El personaje está en modo Turbo");
                }
                else if (accion == 'i')
                {
                    Console.WriteLine("El personaje es Invencible");
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            }

        }
    }
}
