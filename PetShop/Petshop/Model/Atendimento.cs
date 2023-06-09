using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Model
{
	public class Atendimento
	{
		public int idAtendimento { get; set; }
		public Dono_Animal donoAnimal { get; set; }
		public Animal animal { get; set; }
		public Baia baia { get; set; }
		public Servico servico { get; set; }
		public string dataAtendimento { get; set; }
		public string horaAtendimento { get; set; }
		public string profResponsável { get; set; }
		
	}
}
