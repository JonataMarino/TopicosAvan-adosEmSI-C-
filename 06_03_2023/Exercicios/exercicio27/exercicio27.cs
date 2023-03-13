//27-Crie um programa que solicite ao usuário uma frase e exiba na tela a mesma frase,
//mas invertida.

String frase = "";
Console.Write("Digite uma frase: ");
frase = Console.ReadLine();

char[] charArray = frase.ToCharArray();
Array.Reverse(charArray);
Console.WriteLine(charArray);

