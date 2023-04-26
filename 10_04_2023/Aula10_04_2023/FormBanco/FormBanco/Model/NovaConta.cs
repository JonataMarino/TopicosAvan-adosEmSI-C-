using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBanco.Model
{
	internal class NovaConta
	{
		public Cliente cliente = new Cliente() { };


		/*
		public int iDclient { get; set; }
		public string nome { get; set; }
		public string telefone { get; set;}
		public string endereco { get; set; }
		public date dataCriado { get; set; }
		 Cliente
		 */

		public ContaCliente conta = new ContaCliente { };
		/*
		 Conta
        public int idConta { get; set; }
        public string tipoConta { get; set; }
        public string beneficioConta { get; set; }
        public string classeconta { get; set; }
		//
		ContaCliente : Conta
        public decimal limite { get; set; }
        public DateTime dataCriada { get; set; }*/
	}
}
