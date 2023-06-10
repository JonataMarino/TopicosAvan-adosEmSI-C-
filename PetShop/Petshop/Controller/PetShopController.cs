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
		/*	public bool Atualizar(Atendimento atendimento)
			{
				return new PetShopFormService().Atualizar(atendimento);
			}
			public bool Deletar(int id)
			{
				return new PetShopFormService().Deletar(id);
			}
			public Atendimento ConsultarPorId(int id)
			{
				return new PetShopFormService().ConsultarPorId(id);
			}*/
		public List<Atendimento> TodosOsRegistros()
		{
			return new PetShopFormService().TodosOsRegistros();

		}
	}
}
