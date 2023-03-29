// See https://aka.ms/new-console-template for more information
using Aula_27_03_2023;

Console.WriteLine("Contratos de Aplicação");


Person p1 = new Person()
{
	Id = 1,
	Name = "João Silva",
	Age = 30,
	Email = "joaão@teste.com",
	Steps = 0
};

Console.WriteLine(p1);
IPerson person = new Person();
string msg = person.talk();
Console.WriteLine("\n"+msg);

