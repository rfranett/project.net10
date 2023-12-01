using project.net10.models;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um caractere:");
        string entrada = Console.ReadLine();

        if (entrada.Length == 1)
        {
            char caractere = entrada[0];

            if (char.IsLetter(caractere))
            {
                if (caractere == 'a' || caractere == 'e' || caractere == 'i' || caractere == 'o' || caractere == 'u' ||
                    caractere == 'A' || caractere == 'E' || caractere == 'I' || caractere == 'O' || caractere == 'U')
                {
                    Console.WriteLine("É uma vogal");
                }
                else
                {
                    Console.WriteLine("É uma consoante");
                }
            }
            else if (char.IsDigit(caractere))
            {
                Console.WriteLine("É um número");
            }
            else
            {
                Console.WriteLine("É um caractere especial");
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite apenas um caractere.");
        }
    }
}


/*
Console.WriteLine("Digite uma Letra");
String Letra = Console.ReadLine();

switch (Letra)
{   case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    case "A":
    case "E":
    case "I":
    case "O":
    case "U":
        Console.WriteLine("Vogal");
        break;


    default:
        Console.WriteLine("Não é uma Vogal");
        break;


    }*/