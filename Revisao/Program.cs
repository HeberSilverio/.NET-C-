using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opçãoUsuario = ObterOpcaoUsuario();

            while (opçãoUsuario.ToUpper() != "X")
            {
                switch (opçãoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno

                        break;
                    case "2":
                        //TODO: Adicionar aluno
                        break;
                    case "3":
                        //TODO: Adicionar aluno
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opçãoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar aluno");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opçãoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opçãoUsuario;
        }
    }
}
