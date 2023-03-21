// See https://aka.ms/new-console-template for more information
using EX_20_03_2023;

Client client = new Client()
{
	Age = 20,
	Id = 1,
	MotherName = "Ana Silva",
	Name = "José Silva",
	Telephone = "16 9 99999 9999",
	TypePerson = new TypePerson() { Id = 1, Description = "Cliente" }

};

Manager manager = new Manager()
{
	Name = "João Oliveira",
	Age = 40,
	Id = 2,
	Salary = 2000,
	Telephone = "16 98888 8888",
	TypePerson = new TypePerson() { Id = 2, Description = "Gerente" }

};

Console.WriteLine(manager);
Console.WriteLine("============");
Console.WriteLine(client);