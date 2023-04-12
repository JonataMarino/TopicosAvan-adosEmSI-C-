using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoDotNet
{
	public class TypeCoin
	{
		public int Id { get; set; }
		public string coin { get; set; }

		public override string ToString()
		{
			return "\nID da moeda: " + Id +
				"\nNome da moeda: " + coin;
		}
	}
}

