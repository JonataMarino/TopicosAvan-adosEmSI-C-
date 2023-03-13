// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite 3 números: ");

float num1 = float.Parse(Console.ReadLine());
float num2 = float.Parse(Console.ReadLine());
float num3 = float.Parse(Console.ReadLine());

float maior = num1;

if (num1 < num2)
	maior = num2;
if (num1 < num3)
	maior = num3;

Console.WriteLine($"O maior número apresentado é {maior}");
