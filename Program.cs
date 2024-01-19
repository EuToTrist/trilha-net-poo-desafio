using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone+
//FEITO
while (true)
{
Console.WriteLine("QUAL CELULAR VOCE DESEJA USAR");
Console.WriteLine("1 - Iphone");
Console.WriteLine("2 - Nokia");
Console.WriteLine("3 - Sair");

    switch (Console.ReadLine())
    {
        case "1":
            Iphone.TestarIphone();
            break;

        case "2":
            Nokia.TestarNokia();
            break;
        
        case "3":
            Console.WriteLine("Saindo do programa...");
            return;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
}
