using System;
using Instrucoes;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIf(string[] args)
            {
            if (args.Length == 0) {
                Console.WriteLine("Nenhum argumento");
            }   
            else if ( args.Length == 1) {
                Console.WriteLine("Um argumentos");
            }
            else {
                Console.WriteLine($"{args.Length} argumentos");
            }
            }
        static void InstrucaoSwitch(string[] args) {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos) {
                case 0;
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1;
                    Console.WriteLine("um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }            
    }
}
