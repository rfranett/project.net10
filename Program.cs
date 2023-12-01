using project.net10.models;


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


    }