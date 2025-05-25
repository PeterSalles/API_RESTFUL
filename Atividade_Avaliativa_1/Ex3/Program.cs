using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());

        long fatorial = 1;
        int contador = numero;

        while (contador > 1)
        {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine($"Fatorial de {numero} = {fatorial}");
    }
}
/*O código solicita a entrada de um valor para realizar o calculo do fatorial, define uma variavel long para os valores elevados que podem ser atingidos através do cálculo.
Um While é utilizado para realizar a multiplicação do numero inserido pelo seus respectivos antecessores.*/