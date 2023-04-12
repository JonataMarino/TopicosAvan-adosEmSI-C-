using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoDotNet
{
	public class ClientAcc
	{
		public Client Client { get; set; }
		public CC CC { get; set; }
		public CP CP { get; set; }
		public DateTime DateCreate { get; set; }

		public override string ToString()
		{
			return $"Client: {Client}\nCC: {CC}\nCP: {CP}\nDate Create: {DateCreate}";
		}
	}

}
