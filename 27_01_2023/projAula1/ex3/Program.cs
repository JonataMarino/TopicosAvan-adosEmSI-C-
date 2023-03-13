// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual é a sua idade??");
int.TryParse(Console.ReadLine(), out int idade);

String msg = (idade >= 18)? "Maior de idade" : "Menor de idade";
Console.WriteLine(msg);
