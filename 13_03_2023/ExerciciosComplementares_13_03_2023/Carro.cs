using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_13_03_2023
{
	internal class Carro
	{
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Cor { get; set; }
		public int Ano { get; set; }

		public override string ToString()
		{
			return
				"\nMarca: " + Marca +
				"\nModelo: " + Modelo +
				"\nCor: " + Cor +
				"\nAno " + Ano;
		}
	}
}
