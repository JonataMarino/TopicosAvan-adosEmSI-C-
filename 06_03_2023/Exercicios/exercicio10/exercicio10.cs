// See https://aka.ms/new-console-template for more information

int[] numeros = {1, 8, 15, 32, 28, 45, 3, 57, 85, 62};

int maior = 0;
int segundoMaior = 0;

foreach (int i in numeros)
{
	Console.WriteLine(i);
	int numero = i;
	if (numero > maior)
	{
		segundoMaior = maior;
		maior = numero;
	}
	else if (numero > segundoMaior)
	{
		segundoMaior = numero;
	}
}

Console.WriteLine($"\n \nO Segundo maior número é {segundoMaior}");