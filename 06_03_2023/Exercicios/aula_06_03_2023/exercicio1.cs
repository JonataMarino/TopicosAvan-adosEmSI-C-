// See https://aka.ms/new-console-template for more information

float var1, var2;

Console.Write("Informe o primeiro número: ");
var1 = float.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
var2 = float.Parse(Console.ReadLine());

float multip = var1 * var2;
float divis = var1 / var2;
float soma = var1 + var2;
float subtr = var1 - var2;

Console.WriteLine($"Os Resultados Obtidos dos números informados são: \n" +
	$"Soma: {soma}\nSubtração: {subtr}\nMultiplicação: {multip}\n Divisão: {divis}");