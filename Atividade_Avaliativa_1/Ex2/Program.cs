using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira um número: ");
        double Numero = double.Parse(Console.ReadLine());
        Console.WriteLine($"Calculando a tabuada do {Numero}...");

        for (int i = 0; i <= 10; i++) 
        {
            double Resultado = Numero * i;
            Console.WriteLine($"{Numero} x {i} = {Resultado}");
        }
    }
}
