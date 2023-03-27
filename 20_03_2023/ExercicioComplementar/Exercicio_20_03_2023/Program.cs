// See https://aka.ms/new-console-template for more information

using Exercicio_20_03_2023;

ClientAcc clientAcc = new ClientAcc()
{
	Client = new Client() {
		Id = 1,
		Name = "José Sebastião",
		Telephone = "16 999999999",
		Adress = "quinto dos infernos 666",
	},
	CC = new CC()
	{
		Id = 1,
		limit = 2000,
		TypeCoin = new TypeCoin()
		{
			Id = 1,
			coin = "Real"
		},

	},
	CP = new CP()
	{
		saldo = 500,
		TimeStep = 75,
		TxInterest = 0.05,
	},
	DateCreate = DateTime.Now,
};

/*
public class ClientAcc
{
	public Client Client { get; set; }
	public CC CC { get; set; }
	public CP CP { get; set; }
	public DateTime DateCreate { get; set; }
}
}
*/