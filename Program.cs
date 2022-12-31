using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("999999999", "Nokia 3360", "sdkjhg", 64);
Iphone iphone = new Iphone("777777777", "Iphone 3", "agfasg", 128);

nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine($"Número Nokia: {nokia.Numero}");

nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine($"Número Iphone: {iphone.Numero}");

iphone.InstalarAplicativo("Procreate");