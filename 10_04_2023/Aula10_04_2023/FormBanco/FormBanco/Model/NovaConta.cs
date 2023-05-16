using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBanco.Model
{
	public class NovaConta
	{
        public Cliente Cliente { get; set; }
        public ContaCliente ContaCliente { get; set; }
	}
}
