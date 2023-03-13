// See https://aka.ms/new-console-template for more information

Console.Write("Informe o Valor de Um Número Inteiro: ");
float var1 = float.Parse(Console.ReadLine());

if (var1 % 1 == 0)
{
	bool ehPrimo = true;
	for (int i = 2; i < var1; i++)
	{
		if (var1 % i == 0)
			ehPrimo = false;
	}
	if (ehPrimo)
		Console.WriteLine($"{var1} é um numero primo.");
	else
		Console.WriteLine($"{var1} não é um número primo.");
} else
	Console.WriteLine("Este número não é inteiro!");
