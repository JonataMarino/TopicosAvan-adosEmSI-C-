using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAulaOO_13_03_23
{
	class Carro
	{
        #region Propriedades
        public int Id { get; set; }
		public string Name { get; set; }

		public string Color { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public Motor Motor { get; set; }
		#endregion

		#region Métodos 
		public override string ToString()
		{
			return "Id: " + Id +
				   "\nNome: " + Name +
				   "\nCor: " + Color +
				   "\nAno: " + Year +
				   "\nModelo: " + Model;
		}
		#endregion
	}
}