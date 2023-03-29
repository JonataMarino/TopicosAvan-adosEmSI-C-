using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27_03_2023
{
	public class Person : IPerson
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public int Steps { get; set; }

		public string play()
		{
			return "Eba! OOOOOOOH XANAAAINAA";
			//throw new NotImplementedException();
		}

		public void run()
		{
			this.Steps = this.Steps + 2;
			//throw new NotImplementedException();
		}

		public string talk()
		{
			return "Eu adoro falar";
			//throw new NotImplementedException();
		}

		public void walk()
		{
			this.Steps++;
			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return "\nID: " + this.Id +
				"\nNome: " + this.Name +
				"\nE-mail: " + this.Email +
				"\nPassos: " + this.Steps;
		}
	}
}
