// See https://aka.ms/new-console-template for more information
//Faça um programa que leia uma string e informe quantas vezes
//uma determinada letra aparece na string.

string frase = "";
char letra;
int contador = 0;

Console.Write("Digite a frase desejada: ");
frase = Console.ReadLine();

Console.Write("Informe a letra que deseja encontrar as ocorrências: ");
letra = char.Parse(Console.ReadLine());

for (int i = 0; i < frase.Length; i++)
{
	if (frase[i] == letra)
		contador++;
}
Console.WriteLine($"A letra desejada teve um totar de {contador} ocorrências na frase.");




