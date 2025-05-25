using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluido = new List<bool>();
        string opcao;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Marcar tarefa como concluída");
            Console.WriteLine("3 - Listar tarefas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    tarefas.Add(Console.ReadLine());
                    concluido.Add(false);
                    break;

                case "2":
                    Console.Write("Digite o número da tarefa concluída: ");
                    int num = int.Parse(Console.ReadLine()) - 1;
                    if (num >= 0 && num < concluido.Count)
                        concluido[num] = true;
                    else
                        Console.WriteLine("Número inválido.");
                    break;

                case "3":
                    Console.WriteLine("\n--- TAREFAS ---");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluido[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != "4");
    }
}
