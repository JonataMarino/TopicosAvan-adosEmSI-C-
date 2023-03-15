// See https://aka.ms/new-console-template for more information
using ProjAulaOO_13_03_23;

internal class Program
{
	static void Main(string[] args)
	{
		Carro c = new Carro();
		c.Id = 1;
		c.Name = "HB20";
		c.Year = 2019;
		c.Color = "Preto";
		c.Model = "Compacto";
		c.Motor = new Motor()
		{
			Id = 1,
			Description = "Médio",
			Year = 2019
		};

		Carro c2 = new Carro()
		{
			Id = 2,
			Name = "Fiat Toro",
			Year = 2022,
			Color = "Branco",
			Model = "Picape",
			Motor = new Motor()
			{
				Id = 2,
				Description = "Grande",
				Year = 2022
			}
		};

		List<Carro> lstCarro = new List<Carro>();

		lstCarro.Add(c);
		lstCarro.Add(c2);

		//Console.WriteLine(c);

		lstCarro.ForEach(c => Console.WriteLine(c));
	}
}
