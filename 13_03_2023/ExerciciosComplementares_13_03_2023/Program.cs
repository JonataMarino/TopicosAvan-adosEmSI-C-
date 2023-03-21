// See https://aka.ms/new-console-template for more information

using ExerciciosComplementares_13_03_2023;

Pessoa pessoa = new Pessoa()
{
	Nome = "Pedrinho Matador",
	Idade = 36,
	Altura = 1.65f,
	Peso = 65f,
};
Carro carro = new Carro()
{ 
	Marca = "Fiat",
	Modelo = "Uno com Escada",
	Cor = "Branco",
	Ano = 2005
};

List<Pessoa> lstPessoa =  new List<Pessoa>();
List<Carro> lstCarro = new List<Carro>();


lstPessoa.Add(pessoa);
lstCarro.Add(carro);

lstPessoa.ForEach(pessoa => Console.WriteLine(pessoa));
lstCarro.ForEach(carro => Console.WriteLine(carro));



Console.WriteLine("#########################################")
	Console.WriteLine("Ex Lista Supermercado");

List<Itens> lstcompras = new List<Itens>();
/*
Console.Write("Adicione um item a lista: ");
item = string.Parse(Console.ReadLine());
lstcompras.Item(item);
*/

lstcompras.Item("Cebola");

lscompras.ForEach(lstcompras = > Console.WriteLine(lstcompras));