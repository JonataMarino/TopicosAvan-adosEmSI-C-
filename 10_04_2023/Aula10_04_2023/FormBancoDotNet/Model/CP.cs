using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoDotNet
{
	public class CP : Account
	{
		public decimal saldo { get; set; }
		public int TimeStep { get; set; }
		public double TxInterest { get; set; }

		public override string ToString()
		{
			return base.ToString() + ($"\nSaldo da conta: {saldo}\n" +
				$"Criada em: {TimeStep}\n" +
				$"Taxa de Juros: {TxInterest}");
		}
	}
}
