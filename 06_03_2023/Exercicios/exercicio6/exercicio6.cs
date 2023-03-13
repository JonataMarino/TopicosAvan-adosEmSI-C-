// See https://aka.ms/new-console-template for more information
//Faça um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero.
float numero;

Console.Write("Informe um número inteiro: ");
numero = float.Parse(Console.ReadLine());
if (numero % 1 == 0)
{
	if (numero < 0)
	{
		Console.WriteLine("O número informado é negativo.");
	}
	if (numero == 0)
	{
		Console.WriteLine("O Valor do número é igual a 0.");
	}
	if (numero > 0)
		Console.WriteLine("O número informado é positivo.");
}
else
	Console.WriteLine("Informe um número inteiro!");