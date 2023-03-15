// See https://aka.ms/new-console-template for more information

using ExercicoEmSala1;
internal class Progam
{
	static void Main(string[] args)
	{
		Cliente c = new Cliente();
		c.Id = 1;
		c.Nome = "Benito Mussulini";
		c.telefone = "16 99999 9999";
		c.NomePai = "Napoleão Bonaparte";
		c.NomeMae = "Margareth Thatcher";
		c.Endereco = new Endereco()
		{
			Id = 1,
			Logradouro = "Rua dos Tiranos",
			Bairro = "Colo do Capeta",
			Numero = 666,
			Complemento = "Raio que o parta",
			Cep = 66666666

		};

		Cliente c2 = new Cliente()
		{
			Id = 2,
			Nome = "Havaiano Maconheiro",
			telefone = "16 42042 0420",
			NomePai = "Meliante Fumador",
			NomeMae = "Desgostosa Codependente",
			Endereco = new Endereco()
			{
				Id = 2,
				Logradouro = "Rua do Verde",
				Bairro = "Jardim da Neblina",
				Numero = 420,
				Complemento = "Terraço Arborizado",
				Cep = 42042042
			}
		};

		List<Cliente> lstCliente = new List<Cliente>();
		lstCliente.Add(c);
		lstCliente.Add(c2);

		//Console.WriteLine(c);
		//Console.WriteLine(c2);
		lstCliente.ForEach(c => Console.WriteLine(c));

	}
}
