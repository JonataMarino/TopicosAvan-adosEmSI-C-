// See https://aka.ms/new-console-template for more information

#region ex1
Console.WriteLine("====EX1====");
for (int i = 0; i <= 10; i++)
{
	Console.WriteLine(i);
}
#endregion ex1


#region ex2
Console.WriteLine("====EX2====");
List<int> valores= new List<int>();
valores.Add(20);
valores.Add(30);
valores.Add(40);

foreach (var itens in valores)
{
	Console.WriteLine(itens);
}
#endregion ex2

#region ex3
Console.WriteLine("====EX3====");
valores.ForEach(Console.WriteLine	);

#endregion ex3