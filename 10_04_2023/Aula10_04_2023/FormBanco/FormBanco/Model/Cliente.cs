using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBanco.Model
{
    public class Cliente : Pessoa
    {
		public int idCliente { get; set; }
		public DateTime dataCriado { get; set; }

		public override string ToString()
		{
			return "Nome: " + this.nome + " - Data: " + this.dataCriado.ToString();
		}

	}
}
