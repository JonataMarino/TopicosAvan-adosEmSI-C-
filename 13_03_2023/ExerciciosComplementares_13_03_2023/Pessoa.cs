using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_13_03_2023
{
	internal class Pessoa
	{
		public string Nome { get; set;}
		public int Idade { get; set;}
		public float Altura { get; set;}
		public float Peso { get; set;}

		public override string ToString()
		{
			return
				"\nNome: " + Nome +
				"\nIdade: " + Idade +
				"\nAltura: " + Altura +
				"\nPeso: " + Peso +"Kg";
		}
	}
}
