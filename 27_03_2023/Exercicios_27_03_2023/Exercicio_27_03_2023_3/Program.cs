// See https://aka.ms/new-console-template for more information
using Exercicio_27_03_2023_3;

ICalculadora c1 = new Calculadora();

float num1 = 5;
float num2 = 2;

float soma = c1.adicao(num1, num2);
float divisao = c1.divisao(num1, num2);
float multiplicacao = c1.multiplicacao(num1, num2);
float subtracao = c1.subtracao(num1, num2);




Console.WriteLine($"Números aprensentados: {num1} , {num2}" +
	$"\nSoma: {soma}\nSubtração: {subtracao}\n" +
	$"multiplicação: {multiplicacao}\nDivisão: {divisao}");