/**
 * 
 * Nome do Projeto: SimplePigLatinApp
 * Descrição: Converte palavras inseridas pelo usuário para a "língua do Pig Latin (Latin dos Porcos)"
 * respeitando regras de vogais, consoantes e letras maiúsculas.
 * Autor: Rodrigo Lopes (RodrigoLCA)
 * Data:  01.Fevereiro.2026
 * 
 */

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        char[] vogais =
        {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };

        while (true)
        {
            string[] palavras = LerPalavra("Escreva uma palavra: ");
            List<string> resultado_texto = new List<string>();

            if (palavras[0] == "sair")
                break;

            foreach (string p in palavras)
            {
                if (p.Length == 0)
                    continue;

                string palavra = Regex.Replace(p, @"[^a-zA-Zãâáàéèêêìíîòóôõùúû]", "");

                if (string.IsNullOrEmpty(palavra))
                    continue;

                try
                {

                    bool isFirstUppercase = (char.IsUpper(palavra[0]));
                    bool isVowel = vogais.Contains(palavra[0]);
                    string prefixo = palavra;
                    string sufixo = string.Empty;
                    List<char> caracteres = palavra.ToLower().ToList();


                    for (int i = 0; i < caracteres.Count(); i++)
                    {
                        if (vogais.Contains(caracteres[i]))
                        {
                            string primeiraLetra = palavra.Substring(i, 1).ToString();

                            if (isFirstUppercase)
                                primeiraLetra = primeiraLetra.ToUpper();

                            prefixo = primeiraLetra + palavra.Substring(i + 1).ToLower();

                            sufixo = palavra.Substring(0, i).ToLower();

                            break;
                        }
                    }

                    string ay_yay = (isVowel) ? "way" : "ay";

                    string resultado = prefixo + sufixo + ay_yay;

                    resultado_texto.Add(resultado);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            Console.WriteLine(string.Join(" ", resultado_texto));
        }

        Console.WriteLine("Obrigado por usar!");
    }

    static string[] LerPalavra(string prompt)
    {
        Console.WriteLine("---");
        Console.WriteLine(prompt);

        string word = Console.ReadLine() ?? "";

        return word.Split(" ");
    }
}