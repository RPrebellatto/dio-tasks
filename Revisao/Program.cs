using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcao();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine();

                        aluno = informarNota(aluno);
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        Console.WriteLine();
                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome)){
                            Console.WriteLine($"Aluno: {a.Nome}  Nota: {a.Nota}");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for(int i = 0; i < alunos.Length; i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                            notaTotal = notaTotal + alunos[i].Nota;
                            nrAlunos++;
                            }
                        }
                        var media = notaTotal/nrAlunos;
                        Conceito conceitoGeral;
                        if(media < 3)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (media < 5)
                        {
                            conceitoGeral = Conceito.D;
                        }
                         if(media < 7)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (media < 9)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Média: {media} Conceito: {conceitoGeral}");
                        Console.WriteLine();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcao();
            }


        }

        private static Aluno informarNota(Aluno aluno)
        {
            Console.WriteLine("Informe a nota do aluno:");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                throw new ArgumentException("O valor deve ser numérico");
            }

            return aluno;
        }

        private static string ObterOpcao()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar todos os alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
