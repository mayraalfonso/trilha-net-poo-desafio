using DesafioPOO.Models;

// TODO: IMPLEMENTADO!

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "850", modelo: "Modelo GSM 850", imei: "00002515898", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("==========================");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "8745", modelo: "Modelo 6S Plus", imei: "158741965", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");