using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opçãoUsuario = ObterOpcaoUsuario();

            while (opçãoUsuario.ToUpper() != "X")
            {
                switch (opçãoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                        aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        //TODO: Listar aluno
                        foreach(var a in alunos)
                        {
                            if (!a.Nome.Equals(""))
                            {
                            Console.WriteLine($"Aluno: {a.Nome} - {a.Nota}");
                            }
                        }
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
            Console.WriteLine();
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
