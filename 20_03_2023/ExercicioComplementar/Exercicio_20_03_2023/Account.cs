using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20_03_2023
{
	public abstract class Account
	{
		public int Id {  get; set; }
		public string Descricao { get; set; }
		public decimal saldo { get; set; }
		public TypeCoin TypeCoin { get; set; }
		public decimal balance { get; set; }

	}
}
