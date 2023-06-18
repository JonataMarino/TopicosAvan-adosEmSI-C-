using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Model
{
	public class Baia
	{
		public int idBaia { get; set; }
		public string localBaia { get; set; }

		public override string ToString()
		{
			return this.localBaia;
		}
	}
}
