using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_27_03_2023_2
{
	public class Sms : Imensagem
	{

		public string message;

		public string EnviarMensagem(string m) => this.message = message;
	}
}
