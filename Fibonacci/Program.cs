using System;

namespace FibonacciProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //preluam input de la utilizator
            Console.WriteLine("Introduceti un numar pentru a genera secventa Fibonacci pana la acesta:");
            int N;


            //ne asiguram ca utilizatorul introduce un numar intreg valid
            // verificam si daca este numar pozitiv
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out N) && N >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Va rugam să introduceti un numar întreg pozitiv.");
                }
            }

            Console.WriteLine($"Secventa Fibonacci pana la {N}:");
            foreach (int num in Fibonacci.Generate(N))
            {
                Console.Write(num + " ");
            }

            // doar ca sa imi ramana deschis terminalul
            Console.ReadLine();
        }
    }
}