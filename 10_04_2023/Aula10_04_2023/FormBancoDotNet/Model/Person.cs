using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoDotNet
{
	public abstract class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Telephone { get; set; }
		public string Adress { get; set; }

		public override string ToString()
		{
			return "ID Person: " + Id +
				"\nNome: " + Name +
				"\nTelefone: " + Telephone +
				"\nEndereço: " + Adress
				;
		}
	}

}

