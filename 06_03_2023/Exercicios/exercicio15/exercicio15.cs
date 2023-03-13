Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());

if (num < 0)
	Console.WriteLine($"O número {num} é negativo");
else if (num > 0)
	Console.WriteLine($"O numero {num} é positivo");
else
	Console.WriteLine("Seu número corresponde a zero");
