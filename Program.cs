using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia, Teste:");
Smartphone nokia = new Nokia("21995874589", "Nokia Tijolo", "123456789012345", 16);
nokia.Ligar();
nokia.InstalarAplicativo("ZapZap");

Console.WriteLine("\n"); 

Console.WriteLine("\nSmartphone iPhone, Teste:");
Smartphone iphone = new Iphone("1154875425", "iPhone 11 Pro Max Gold", "987654321098765", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("X");
