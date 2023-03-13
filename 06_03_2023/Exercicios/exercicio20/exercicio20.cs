//Crie um programa que solicite ao usuário um número e exiba na tela a sua tabuada
//de multiplicação e de divisão, de 1 a 10.

Console.Write("Digite um numero para tabuada: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("================");
Console.WriteLine("MUTIPLICAÇÃO");
for (int i = 1; i <= 10; i++)
	Console.Write($"{num} x {i} = {num * i}\n");
Console.WriteLine("================");

Console.WriteLine("DIVISÃO");
for (int i = 1; i <= 10; i++)
	Console.Write($"{num} / {i} = {num / i}\n");
Console.WriteLine("================");