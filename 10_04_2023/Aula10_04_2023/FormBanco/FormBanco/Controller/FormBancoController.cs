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
			return new BancoFormService().InserirCliente(novaconta);
		}
		public bool Atualizar(NovaConta novaconta)
		{
			return new BancoFormService().Atualizar(novaconta);
		}
		public bool Deletar(int id)
		{
			return new BancoFormService().Deletar(id);
		}
		public NovaConta ConsultarPorId(int id)
		{
			return new BancoFormService().ConsultarPorId(id);
		}
		public List<NovaConta> TodosOsRegistros()
		{
			return new BancoFormService().TodosOsRegistros();

		}
	}
}
