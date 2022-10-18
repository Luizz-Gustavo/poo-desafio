using DesafioPOO.Models;

Console.WriteLine("Nokia");

Nokia n1 = new Nokia("(00)0000-0000", "Nokia C3", "000000000000000", 64);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone i1 = new Iphone("(11)1111-1111", "Iphone 14 PRO MAX ", "111111111111111", 256);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Telegram");