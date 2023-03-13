// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Valor A: ");
int.TryParse(Console.ReadLine(), out int a);
Console.Write("Valor B: ");
int.TryParse(Console.ReadLine(), out int b);

Console.WriteLine($"a soma de A + B = {(a + b)}");