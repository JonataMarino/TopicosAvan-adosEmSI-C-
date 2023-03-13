
int idAnimal = 0;
int option = 0;
List<string> animais = new List<string>();
List<float> weight = new List<float>();


Console.WriteLine("CADASTRO ANIMAL");

while (idAnimal < 10)
	{ 
		Console.Write("Informe o nome do Animal: ");
		string name = Console.ReadLine();
		animais.Add(name);
		
		Console.Write("Informe o peso do Animal: ");
	    float.TryParse(Console.ReadLine(), out float peso);
		weight.Add(peso);

	idAnimal++;
	}

float maiorPeso = weight.Max();
int IndexMaiorPeso = weight.IndexOf(weight.Max());
string animalMaiorPeso = animais[IndexMaiorPeso];

	Console.WriteLine($"\nO Animal com maior peso é {animalMaiorPeso}, pesando {maiorPeso}kgs");

