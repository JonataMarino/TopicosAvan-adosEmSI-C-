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
		public TypeCoin TypeCoin { get; set; }
		public TypeAcc TypeAcc { get; set; }

		public override string ToString()
		{
			return "\nID da conta: " + Id +
				"\nDescrição da conta: " + Descricao +
				"\nTipo de Moeda: " + TypeCoin +
				"\nTipo de Conta: " + TypeAcc
				;
		}
	}
}
