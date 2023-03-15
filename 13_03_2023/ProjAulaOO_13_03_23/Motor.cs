using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAulaOO_13_03_23
{
	class Motor
	{
		#region Propriedades
		public int Id { get; set; }
		public string Description { get; set; }
		public int Year { get; set; }
		#endregion

		#region Métodos
		public override string ToString()
		{
			return "Id: " + Id +
				   "Descrição: " + Description +
				   "Ano: " + Year;
		}
		#endregion

	}
}