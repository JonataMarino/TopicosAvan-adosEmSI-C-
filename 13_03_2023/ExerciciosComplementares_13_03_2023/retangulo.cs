using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_13_03_2023
{ 
	internal class retangulo
	{
			private double comprimento;
			private double largura;

			public retangulo(double comprimento, double largura)
			{
				this.comprimento = comprimento;
				this.largura = largura;
			}

			public double GetComprimento()
			{
				return comprimento;
			}

			public void SetComprimento(double comprimento)
			{
				this.comprimento = comprimento;
			}

			public double GetLargura()
			{
				return largura;
			}

			public void SetLargura(double largura)
			{
				this.largura = largura;
			}

			public double CalcularArea()
			{
				return comprimento * largura;
			}

			public double CalcularPerimetro()
			{
				return 2 * (comprimento + largura);
			}
		}
	}
}