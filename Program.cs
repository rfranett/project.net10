using project.net10.models;


 {
        Console.WriteLine("Digite um caractere:");
        string entrada = Console.ReadLine();

        if (entrada.Length == 1)
        {
            char caractere = entrada[0];

            switch (caractere)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("É uma vogal");
                    break;

                default:
                    if (char.IsDigit(caractere))
                    {
                        Console.WriteLine("É um número");
                    }
                    else
                    {
                        Console.WriteLine("É uma consoante ou caractere especial");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite apenas um caractere.");
        }}
/*
===================================================================================ex2
{
    Console.WriteLine("Digite um caractere:");
    string entrada = Console.ReadLine();

    if (entrada.Length == 1)
    {
        char caractere = entrada[0];

        switch (caractere)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("É uma vogal");
                break;

            case >= '0' and <= '9':
                Console.WriteLine("É um número");
                break;

            default:
                Console.WriteLine("É um caractere especial");
                break;
        }
    }
    else
    {
        Console.WriteLine("Por favor, digite apenas um caractere.");
    }
}

=========================================================================ex1
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