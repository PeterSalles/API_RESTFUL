using System;
using System.Text;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou frase:");
        string entrada = Console.ReadLine();

        string textoLimpo = RemoverEspacosEAcentos(entrada.ToLower());

        string textoReverso = InverterTexto(textoLimpo);

        if (textoLimpo == textoReverso)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }

    static string RemoverEspacosEAcentos(string texto)
    {
        // Remove espaços
        texto = texto.Replace(" ", "");

        // Remove acentos
        var textoNormalizado = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (char c in textoNormalizado)
        {
            UnicodeCategory cat = CharUnicodeInfo.GetUnicodeCategory(c);
            if (cat != UnicodeCategory.NonSpacingMark)
                sb.Append(c);
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }

    static string InverterTexto(string texto)
    {
        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
