// See https://aka.ms/new-console-template for more information
float var1;

Console.Write("Informe um numero inteiro: ");
var1 = float.Parse(Console.ReadLine());

if (var1 % 1 == 0)
{
	if(var1 % 2 == 0){
		Console.WriteLine($"{var1} é número par!");
	}else
		Console.WriteLine($"{var1} não é um número par!");

} else
	Console.WriteLine("Este não é um número inteiro!!!");
