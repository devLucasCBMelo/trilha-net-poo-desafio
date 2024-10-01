using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone apple = new Iphone("(83) 99999-8888", "iphone-16", "777777", 66666);

apple.Ligar();
apple.InstalarAplicativo("whatsapp");
apple.ReceberLigacao();
apple.Numero = "(83) 98888-5555";

Console.WriteLine("\n");

Nokia nokia = new Nokia("(82) 91111-2222", "indestrutivel-62", "87aska3", 551234);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();