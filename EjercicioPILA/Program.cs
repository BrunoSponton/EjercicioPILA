using System;
using System.Collections.Generic;

class EjercicioPILA
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>();

        while (true)
        {
            Console.Write("Introducir una cadena (presionar Enter para terminar): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            pila.Push(input);
        }

        Console.WriteLine("Cadenas introducidas en orden inverso:");

        while (pila.Count > 0)
        {
            string cadena = pila.Pop();
            Console.WriteLine(cadena);
        }
    }
} 
