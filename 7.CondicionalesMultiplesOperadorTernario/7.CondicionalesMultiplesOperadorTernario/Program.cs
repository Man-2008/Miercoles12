using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
            Si el día es martes o jueves, se realizará un descuento del 15% por la compra.  
            Si el día es lunes o miércoles, se realizará un descuento del 10% por la compra. 
            Si el día es viernes o sábado, se realizará un descuento del 20% por la compra. 
            Si es domingo no se realiza descuento. 
            Visualizar el día, el descuento y el total a pagar por la compra.

            string diaSemana = "";
            float subtotal = 0;
            float descuento = 0;

            Console.WriteLine("Ingrese el monto de la compra");
            subtotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana");
            diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case "Lunes":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es {diaSemana}, el descuento es de: {descuento}, por lo tanto el total a pagar sera: {subtotal - descuento}");
                    break;
                case "Martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es {diaSemana}, el descuento es de: {descuento}, por lo tanto el total a pagar sera: {subtotal - descuento}");
                    break;
                case "Miercoles":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es {diaSemana}, el descuento es de: {descuento}, por lo tanto el total a pagar sera: {subtotal - descuento}");
                    break;
                case "Jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es {diaSemana}, el descuento es de: {descuento}, por lo tanto el total a pagar sera: {subtotal - descuento}");
                    break;
                case "Viernes":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es {diaSemana}, el descuento es de: {descuento}, por lo tanto el total a pagar sera: {subtotal - descuento}");
                    break;
                case "Sabado":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es {diaSemana}, el descuento es de: {descuento}, por lo tanto el total a pagar sera: {subtotal - descuento}");
                    break;
                case "Domingo":
                    descuento = 0;
                    Console.WriteLine($"Hoy es {diaSemana}, el descuento es de: {descuento}, por lo tanto el total a pagar sera: {subtotal - descuento}");
                    break;

                default:
                    Console.WriteLine("Eror: Ingrese solo un dia de la semana con mayuscula inicial");
                    break;
            }*/



            float num1 = 0.0f;
            float num2 = 0.0f;
            string operacion = "";
            float resultado = 0.0f;

            Console.WriteLine("¿Que operacion desea realizar?");
            operacion = Console.ReadLine();
            Console.WriteLine("Ingrese el primer numero");
            num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo numero");
            num2 = Single.Parse(Console.ReadLine());

            switch (operacion)
            {
                case "Suma":
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la {operacion} fue: {resultado}");
                    break;
                case "Resta":
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la {operacion} fue: {resultado}");
                    break;
                case "Multiplicacion":
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la {operacion} fue: {resultado}");
                    break;
                case "Division":
                    resultado = num1 / num2;
                    Console.WriteLine($"El resultado de la {operacion} fue: {resultado}");
                    break;
                default:
                    Console.WriteLine("Escriba el nombre de la operacion en mayuscula inicial");
                    Console.WriteLine("Ingrese solo numeros enteros o decimales");
                    break;
            }
        }
    }
}
