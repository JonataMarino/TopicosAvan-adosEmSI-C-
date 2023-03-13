//-Crie um programa que solicite ao usuário um número e exiba na tela
//a sequência de Fibonacci até esse número.

		int n = 10; // Número de termos a serem exibidos
		int primeiro = 0, segundo = 1, proximo;

		Console.Write(primeiro + " " + segundo + " ");

		for (int i = 3; i <= n; i++)
		{
			proximo = primeiro + segundo;
			Console.Write(proximo + " ");

			primeiro = segundo;
			segundo = proximo;
		}
