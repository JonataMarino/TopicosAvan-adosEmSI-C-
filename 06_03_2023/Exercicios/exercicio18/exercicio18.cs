// See https://aka.ms/new-console-template for more information
//Crie um programa que solicite ao usuário uma frase e exiba na
//tela quantas vezes cada letra aparece na frase.

using System.Globalization;
string frase;
Console.Write("Digite uma frase a frase desejada: ");
frase = Console.ReadLine().ToLower();
int[] contador = new int[26];
foreach (char letra in frase) { 
	if (Char.IsLetter(letra))
	{
		int indice = (int)letra - (int)'a';
		contador[indice]++;
	}
}
for (int i = 0; i < 26; i++)
{
	if (contador[i] > 0)
	{
		char letra = (char)(i + (int)'a');
		Console.Write($"A letra {letra} se repete {contador[i]} vezes na frase\n");
	}
}