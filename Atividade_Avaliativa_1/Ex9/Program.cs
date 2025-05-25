using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101);
        int tentativas = 0;
        int palpite = 0;

        Console.WriteLine("Jogo da Adivinhação! Tente adivinhar o número entre 1 e 100.");

        while (palpite != numeroSecreto)
        {
            Console.Write("Seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto)
                Console.WriteLine("O número é MAIOR.");
            else if (palpite > numeroSecreto)
                Console.WriteLine("O número é MENOR.");
        }

        Console.WriteLine($"\nParabéns! Você acertou em {tentativas} tentativas.");
    }
}
