using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//  5)Crie uma classe em C# que modele uma lista de compras,
//com métodos para adicionar itens, remover itens e exibir
//a lista completa.


namespace ExerciciosComplementares_13_03_2023
{
	class Itens
	{
		public string Item { get; set; }


		#region  
		public string Additem(item)
		{
			string item = ""; 
			Console.WriteLine("Adicionar item: ");
			string.Parse(item);
			this item = Item;
		}

		public void DeleteItem(ref string item)
		{
			item = null;
			this Item = item;
			Console.WriteLine("Item Apagado da Lista");

		}
#endregion

		//public override string ToString()
		//{
		//	return "Item: " + Item;
			
	//	}
//}
	Itens itens = new Itens();

	


	//int num = int.Parse(Console.ReadLine());
