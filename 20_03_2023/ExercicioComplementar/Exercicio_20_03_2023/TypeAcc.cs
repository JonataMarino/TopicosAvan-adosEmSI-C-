using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20_03_2023
{
	public class TypeAcc
	{
		public int id { get; set; }
		public string descricao { get; set; }
		public BonusTypeAcc BonusTypeAcc { get; set; }

		public override string ToString()
		{
			return "\nID do beneficio: " + id +
				"\nNivel do Benefício: " + descricao +
				"\nTipo de beneficios: " + BonusTypeAcc;
		}
	}
}
