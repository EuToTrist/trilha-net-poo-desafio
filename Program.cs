using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone+
//FEITO
Console.WriteLine("QUAL CELULAR VOCE DESEJA USAR");
Console.WriteLine("1 - Iphone");
Console.WriteLine("2 - Nokia");

switch (Console.ReadLine())
{
    case "1" :
        Iphone.TestarIphone();
        break;

    case "2" :
        Nokia.TestarNokia();
        break;

    default:
        Console.WriteLine("Opção invalida");
        break;
}

