using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma senha:");
        string senha = Console.ReadLine();

        static bool VerificaSenha(string senha)
        {
            if (senha.Length < 8)
                return false;
            bool Maiuscula = Regex.IsMatch(senha, "[A-Z]");
            bool Numero = Regex.IsMatch(senha, "[0-9]");
            bool Especial = Regex.IsMatch(senha, "[!@#$%^&*(),.?\":{}|<>]");
            return Maiuscula && Numero && Especial;
        }
    if (VerificaSenha(senha))
        {
            Console.WriteLine("Senha válida");
        }
        else
        {
            Console.WriteLine("Senha inválida");
        }
    }
}
