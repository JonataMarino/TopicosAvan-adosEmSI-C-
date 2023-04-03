using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_27_03_2023_3
{
	public class Calculadora : ICalculadora
	{
		public float num1 { get; set; }
		public float num2 { get; set; }



		public float adicao(float num1, float num2)
		{
			float resultado = num1 + num2;
			return resultado;
		}

		public float divisao(float num1, float num2)
		{
			float resultado = num1 / num2;
			return resultado;
		}

		public float multiplicacao(float num1, float num2)
		{
			float resultado = num1 * num2;
			return resultado;
		}

		public float subtracao(float num1, float num2)
		{
			float resultado = num1 - num2;
			return resultado;
		}
	}
}
