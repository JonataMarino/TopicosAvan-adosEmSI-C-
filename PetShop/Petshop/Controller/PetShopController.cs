using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Model;
using Petshop.Service;

namespace Petshop.Controller
{
	class PetShopController
	{
		public bool InserirAtendimento(Atendimento atendimento)
		{
			return new PetShopFormService().InserirAtendimento(atendimento);
		}
		public Atendimento CarregarAtendimento(Atendimento atendimento)
		{
			return new PetShopFormService().CarregarAtendimento(atendimento);
		}
		public Atendimento AtualizarAtendimento(Atendimento atendimento)
		{
			return new PetShopFormService().AtualizarAtendimento(atendimento);
		}
		public bool ExcluirAtendimento(int id)
		{
			return new PetShopFormService().ExcluirAtendimento(id);
		}

		
		public List<Atendimento> TodosOsRegistros()
		{
			return new PetShopFormService().TodosOsRegistros();

		}
	}
}
