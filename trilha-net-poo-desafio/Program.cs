using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "+55 (66) 9.8465-8465", modelo: "Wondows Phone", imei: "123456789012345", memoria: "128 Gb");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"Memória: {nokia.Memoria}");
Console.WriteLine($"Número: {nokia.Numero}");

Console.WriteLine("\nSmartphone Iphone:");
Iphone iphone = new Iphone(numero: "+55 (66) 9.8465-8465", modelo: "Iphone 16 - Pro Max", imei: "987654321098765", memoria: "512 Gb");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"Memória: {iphone.Memoria}");
Console.WriteLine($"Número: {iphone.Numero}");