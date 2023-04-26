using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormBanco.Model;
using FormBanco.Service;

namespace FormBanco.Controller
{
	class FormBancoController
	{
		public bool Inserir(NovaConta novaconta)
		{
			return new BancoFormService().Inserir(novaconta);
		}

		public List<NovaConta> TodosOsRegistros()
		{
			return new BancoFormService().TodosOsRegistros();
		}
	}
}
