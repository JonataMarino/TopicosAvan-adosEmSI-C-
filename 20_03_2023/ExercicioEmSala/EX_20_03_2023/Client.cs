using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_20_03_2023
{
	class Client : Person
	{
		public string MotherName { get; set; }

		public override string ToString()
		{
			return "TIPO: " + this.TypePerson.Description + "\n" +
				base.ToString() + "\nNome da Mãe: " + MotherName;
		}
	}
}
