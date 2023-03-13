// See https://aka.ms/new-console-template for more information

int[] valores;
int NumUser;

Console.Write("Informe a quantidade de números a ser declarados: ");
NumUser = int.Parse(Console.ReadLine());

double soma = 0;
valores = new int[NumUser];
for (int i = 0; i < valores.Length; i++)
{
	Console.Write("Informe um numero para soma: ");
	valores[i] = int.Parse(Console.ReadLine()); 
	soma += valores[i];
}
double media = soma / NumUser;
Console.WriteLine($"O Valor da média entre os números informados é {media}");