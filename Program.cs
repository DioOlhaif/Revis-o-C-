using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos[] alunos = new Alunos[5];
            var IndiceAluno = 0;
            string OpcaoUsuario = ObterOpcaoUsuario();
            double total=0;
            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar Alunos
                        Alunos aluno = new Alunos();
                        Console.WriteLine("Informe o nome do Aluno:  ");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a note do Aluno:");
                        aluno.Nota = double.Parse(Console.ReadLine());
                        
                        alunos[IndiceAluno] = aluno;
                        IndiceAluno++;
                        total +=aluno.Nota;

                   
                        
                        break;

                    case "2":
                        //TODO: Listar Alunos 
                       
                        foreach( var a in alunos)
                        {
                            Console.WriteLine($"ALUNO: {a.Nome} NOTA:{a.Nota}");
                            
                        }
                        

                        break;

                    case "3":
                        //TODO: Media Geral dos Alunos

                        double media;
                        media = total / alunos.Length;
                        Console.WriteLine("A média geral da turma é: " + media);







                        break;

                    default:

                        throw new ArgumentOutOfRangeException("informe valor valido");


                }

                OpcaoUsuario = ObterOpcaoUsuario();
                
        
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a Opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listas de alunos");
            Console.WriteLine("3- Calcular Média geral");
            Console.WriteLine("X- Sair");

            string OpcaoUsuario = Console.ReadLine();
            return OpcaoUsuario;
        }
    }
}
