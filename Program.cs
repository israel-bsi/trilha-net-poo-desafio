using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Spartphone Nokia");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 512);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSpartphone Iphone");
Smartphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 1024);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");