using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(11) 9 8177-5199", modelo: "N95", imei:"1111111", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(numero: "(21) 9 9272-2627)", modelo: "Iphone 12", imei: "2222222", memoria:512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");




