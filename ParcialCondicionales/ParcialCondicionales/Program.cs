using System;
using System.Text.RegularExpressions;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un conjunto de personas ha sido clasificado en cuatro grupos denominados A, B, C y D, según tres criterios: sexo, edad y último dígito del documento de identidad. La asignación a los grupos se realiza de acuerdo con las siguientes reglas:
            Grupo A
                Pertenecen al grupo A las personas que cumplan alguna de estas dos condiciones:
                    Mujeres con edad entre 16 y 20 años(inclusive), y cuyo documento de identidad termine en 0, 4 o 8.
                    Hombres con edad entre 18 y 22 años(inclusive), y cuyo documento de identidad termine en 1, 5 o 9.
            Grupo B
                Pertenecen al grupo B las personas que cumplan alguna de estas dos condiciones:
                    Mujeres con edad entre 21 y 25 años(inclusive), y cuyo documento de identidad termine en 3 o 7.
                    Hombres con edad entre 23 y 26 años(inclusive), y cuyo documento de identidad termine en 2 o 6.
            Grupo C
                Pertenecen al grupo C las personas de cualquier sexo que cumplan ambas condiciones:
                    Tienen 15 años de edad
                    Dominen el idioma inglés
                    Nota: Solo se debe preguntar sobre el dominio del inglés si la persona tiene 15 años.
            Grupo D
                Pertenecen al grupo D todas aquellas personas que no cumplen con ninguno de los criterios anteriores.
            Objetivo del programa
            Desarrolla un programa que:
            Solicite al usuario los siguientes datos:
            Sexo(masculino o femenino)
            Edad(número entero positivo)
            Último dígito del documento de identidad(número del 0 al 9)
            Dominio del idioma inglés(solo si tiene 15 años, como “sí” o “no”)
            Analice la información ingresada y determine a qué grupo pertenece la persona.
            Muestre en pantalla el grupo correspondiente.*/

            string sexo = "";
            int edad = 0;
            int NumID = 0;
            string domIdioma = "";

            Console.WriteLine("Por favor ingrese los siguientes datos");
            Console.WriteLine("Sexo");
            sexo = Console.ReadLine();
            Console.WriteLine("Edad");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ultimo digito del documento de identidad");
            NumID = Int32.Parse(Console.ReadLine());

            if (sexo == "Mujer")
            {
                //Grupo A

                if (edad >= 16 && edad <= 20 && NumID == 0 | NumID == 4 | NumID == 8)
                {
                    Console.WriteLine("Pertenece al grupo A");
                }

                //Grupo B

                else if (edad >= 21 && edad <= 25 && NumID == 3 | NumID == 7)
                {
                    Console.WriteLine("Pertenece al grupo B");
                }

                //Grupo C

                else if (edad == 15)
                {
                    Console.WriteLine("¿Tienes un buen dominio del idioma Ingles? (Si/No)");
                    domIdioma = Console.ReadLine();
                    
                    if (domIdioma == "Si")
                    {
                        Console.WriteLine("Pertenece al grupo C");
                    }
                    else if (domIdioma == "No")
                    {
                        Console.WriteLine("Pertenece al grupo D");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Pertenece al grupo D");
                }
            }
            else if (sexo == "Hombre")
            {
                //Grupo A

                if (edad >= 18 && edad <= 22 && NumID == 1 | NumID == 5 | NumID == 9)
                {
                    Console.WriteLine("Pertenece al grupo A");
                }

                //Grupo B

                else if (edad >= 23 && edad <= 26 && NumID == 2 | NumID == 6)
                {
                    Console.WriteLine("Pertenece al grupo B");
                }

                //Grupo C

                else if (edad == 15)
                {
                    Console.WriteLine("¿Tienes un buen dominio del idioma Ingles? (Si/No)");
                    domIdioma = Console.ReadLine();

                    if (domIdioma == "Si")
                    {
                        Console.WriteLine("Pertenece al grupo C");
                    }
                    else if (domIdioma == "No")
                    {
                        Console.WriteLine("Pertenece al grupo D");
                    }

                }
                else
                {
                    Console.WriteLine("Pertenece al grupo D");
                }
            }
            
        }
    }
}
