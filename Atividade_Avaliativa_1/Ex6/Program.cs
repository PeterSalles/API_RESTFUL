using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();

            Console.WriteLine($"\nCadastro do Produto {i + 1}");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Lista de Produtos ---");

        foreach (Produto p in produtos)
        {
            Console.WriteLine($"Produto: {p.Nome} | Preço: R${p.Preco:F2} | Quantidade: {p.Quantidade} | Total em estoque: R${p.ValorTotalEmEstoque():F2}");
        }
    }
}
