Console.Write("Digite um numero para tabuada: ");
int num = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
	Console.Write($"{num} x {i} = {num * i}\n");