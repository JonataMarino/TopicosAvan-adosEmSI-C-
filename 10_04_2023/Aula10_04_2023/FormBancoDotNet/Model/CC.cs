using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoDotNet
{
	public class CC : Account
	{
		public decimal limit { get; set; }

		public override string ToString()
		{
			return base.ToString() + "\nLimite do cheque especial: " + limit;
		}
	}

}
