// See https://aka.ms/new-console-template for more information

using Exercicio_20_03_2023;

class Program
{
	static void Main(string[] args)
	{

		ClientAcc clientAcc = new ClientAcc()
		{
			Client = new Client()
			{
				Id = 1,
				Name = "José Sebastião",
				Telephone = "16 999999999",
				Adress = "quinto dos infernos 666",
			},
			CC = new CC()
			{
				Id = 1,
				Descricao = "Conta Corrente",
				limit = 2000,
				TypeCoin = new TypeCoin()
				{
					Id = 1,
					coin = "Real(BRL)"
				},
				TypeAcc = new TypeAcc()
				{
					id = 1,
					descricao = "Platina no nariz",
					BonusTypeAcc = new BonusTypeAcc()
					{
						id = 1,
						descricao = "pack de pé da pipokinha",
					},
				},

			},
			CP = new CP()
			{
				Id = 1,
				Descricao = "conta - poupança",
				saldo = 500,
				TimeStep = 75,
				TxInterest = 0.05,
				TypeCoin = new TypeCoin()
				{
					Id = 1,
					coin = "Real"
				},
				TypeAcc = new TypeAcc()
				{
					id = 1,
					descricao = "A esperança do pobre",
					BonusTypeAcc = new BonusTypeAcc()
					{
						id = 1,
						descricao = "pode fazer pix",
					},
				},
			},
			DateCreate = DateTime.Now,
		};
		List<ClientAcc> lstclient = new List<ClientAcc>();
		lstclient.Add(clientAcc);


		lstclient.ForEach(clientAcc => Console.WriteLine(clientAcc));


	}
}