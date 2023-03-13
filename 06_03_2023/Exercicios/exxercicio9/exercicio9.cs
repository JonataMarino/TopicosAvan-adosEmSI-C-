// See https://aka.ms/new-console-template for more information
// Faça um programa que leia um número inteiro e informe se ele é um
// número perfeito. Um número perfeito é aquele cuja soma dos seus
// divisores (exceto ele mesmo) é igual ao próprio número.
//Em matemática, um número perfeitoé um número naturalpara o qual a
//soma de todos os seus divisoresnaturaispróprios (excluindo ele mesmo)
//é igual ao próprio número. Por exemplo, o número 28 é,
//pois: 28 = 1 + 2 + 4 + 7 + 14{ displaystyle ,!28 = 1 + 2 + 4 + 7 + 14}.

Console.Write("Informe o número desejado: ");
int n = int.Parse(Console.ReadLine());

float soma = 0;
for  (int i = 1; i < n; i++)
	if (n % i == 0)
		soma += i;

if (soma == n)
	Console.WriteLine($"O número {n} é um número primo!");
else
	Console.WriteLine($"O Numero {n} não é um numero primo!");