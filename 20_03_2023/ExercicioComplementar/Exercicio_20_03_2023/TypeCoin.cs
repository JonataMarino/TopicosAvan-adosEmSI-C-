using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20_03_2023
{
	public class TypeCoin
	{
		public int Id { get; set; }
		public string coin { get; set; }

		public override string ToString()
		{
			return "\nID da moeda: " + Id +
				"\nNome da moeda: " + coin ;
		}
	}
}
