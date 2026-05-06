using System;

namespace VariablesConsantesTiposdeDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores
            // Operadores numericos
            //Cambio de signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = -num2;
            Console.WriteLine(num1 + " " + num2 + " " + num3);
            //Aritmeticos
            int num4 = 3 + num1;
            int num5 = 12 - num3;
            int num6 = 26 * num4;
            float num7 = (float)3 / 2; //float 3f/2f para que funcione
            Console.WriteLine("Suma:{0}, resta: {1}, multiplicacion: {2}, division: {3}", num4, num5, num6, num7);
            //incremento y decremento
            num4++; //num4=num4+1;
            num5--;
            num6 += 4;
            num4 -= 10;
            num5 *= 5;
            num1 /= 5;
            num6 *= num4;
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", num4, num5, num6, num4, num5, num1, num6);
            int num8 = 3 * 4 / 2;
            int num9 = 4 * (3 / 2);
            int num10 = 4 + 6 * (2 - 1);
            // Operadores Logicos
            // Conjuncion = Y - AND - &&    
            Console.WriteLine("TABLA DE VERDAD CONJUNCION");
            Console.WriteLine("V Y V:" + (true && true));
            Console.WriteLine("V Y F:" + (true && false));
            Console.WriteLine("F Y V:" + (false && true));
            Console.WriteLine("F Y F:" + (false && false));
            Console.WriteLine("----------------------------");
            // Disyuncion = O - OR - ||  
            Console.WriteLine("TABLA DE VERDAD DISYUNCION");
            Console.WriteLine("V O V:" + (true || true));
            Console.WriteLine("V O F:" + (true || false));
            Console.WriteLine("F O V:" + (false || true));
            Console.WriteLine("F O F:" + (false || false));
            Console.WriteLine("----------------------------");
            //Operadores de Comparacion
            bool dato1 = 4 > 5;
            bool dato2 = 16 != 100;
            bool dato3 = 1 == 1;
            bool dato4 = !dato3;
            bool dato5 = 100 < 200 || dato3 && true;

        }
    }
}
