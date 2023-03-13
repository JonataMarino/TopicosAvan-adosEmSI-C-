// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Xml.Schema;

int n;
int fatorial = 1;
Console.Write("Informe o número que que deseja fatorar: ");
n = int.Parse(Console.ReadLine());

for (int i = n; i >= 1; i--)
{
	fatorial *= i;
	
}
Console.WriteLine(fatorial);
