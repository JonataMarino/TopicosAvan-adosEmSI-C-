using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_27_03_2023_2
{
	public class Email : Imensagem
	{
		public string message { get; set; }

		public string EnviarMensagem(string message) => this.message = message;
	}
}
