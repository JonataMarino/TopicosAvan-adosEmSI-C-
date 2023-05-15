using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormBanco.Model;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FormBanco.Service
{
	class BancoFormService
	{
		string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security = true; AttachDbFileName=D:\Logaatti-7termo\TopicosAvancadosEmSI\10_04_2023\Aula10_04_2023\Banco\bancodb.mdf;";
		SqlConnection conn;

		public BancoFormService()
		{
			conn = new SqlConnection(strCon);
			conn.Open();
		}

		public bool InserirCliente(NovaConta novaconta)
		{
			string strInsertConta;
			string strInsertCliente;
			
			strInsertCliente = "insert into tbl_cliente" +
				"(nomecliente, telefoneCliente, enderecoCliente, dataCriado)" +
			"values" +
			"(@nomeCliente, @telefoneCliente, @enderecoCliente, @dataCriado)";
			SqlCommand commandInsertCliente = new SqlCommand(strInsertCliente, conn);

			commandInsertCliente.Parameters.Add(new SqlParameter("@nomeCliente", novaconta.Cliente.nome));
			commandInsertCliente.Parameters.Add(new SqlParameter("@telefoneCliente", novaconta.Cliente.telefone));
			commandInsertCliente.Parameters.Add(new SqlParameter("@enderecoCliente", novaconta.Cliente.endereco));
			commandInsertCliente.Parameters.Add(new SqlParameter("@dataCriado", novaconta.Cliente.dataCriado));

			strInsertConta = "insert into tbl_conta" +
				"(tipoConta, beneficioConta, classeConta, contaLimite, dataCriada)" +
			"values" +
			"(@tipoConta, @beneficioConta, @classeConta, @contaLimite, @dataCriada)";
			SqlCommand commandInsertConta = new SqlCommand(strInsertConta, conn);

			commandInsertConta.Parameters.Add(new SqlParameter("@tipoConta", novaconta.ContaCliente.tipoConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@beneficioConta", novaconta.ContaCliente.beneficioConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@classeConta", novaconta.ContaCliente.classeConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@contaLimite", novaconta.ContaCliente.limite));
			commandInsertConta.Parameters.Add(new SqlParameter("@dataCriada", novaconta.ContaCliente.dataCriada));



			commandInsertCliente.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public List<NovaConta> TodosOsRegistros()
		{
			List<NovaConta> novascontas = new List<NovaConta>();

			StringBuilder sb = new StringBuilder();

			sb.Append(" SELECT cliente.idcliente, ");
			sb.Append(" 	   cliente.nomeCliente,  ");
			sb.Append(" 	   cliente.telefoneCliente, ");
			sb.Append(" 	   cliente.enderecoCliente,");
			sb.Append(" 	   cliente.dataCriado, ");
			sb.Append(" 	   conta.idConta,");
			sb.Append(" 	   conta.tipoConta, ");
			sb.Append(" 	   conta.beneficioConta, ");
			sb.Append(" 	   conta.classeConta, ");
			sb.Append(" 	   conta.contaLimite, ");
			sb.Append(" 	   conta.dataCriada ");
			sb.Append(" FROM tbl_cliente cliente left join TBL_CONTA conta ");
			sb.Append("   on cliente.idcliente = conta.idcliente ");


			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			SqlDataReader dr = commandSelect.ExecuteReader();

			while (dr.Read())
			{
				NovaConta novaconta = new NovaConta();

				novaconta.Cliente = new Cliente()
				{
					idCliente = Convert.ToInt32(dr["idcliente"]),
					nome = (string)dr["nomeCliente"],
					telefone = (string)dr["telefoneCliente"],
					endereco = (string)dr["enderecoCliente"],
					dataCriado = DateTime.Parse((string)dr["dataCriado"])
				};
				novaconta.ContaCliente = new ContaCliente()
				{
					beneficioConta = (string)dr["beneficioConta"],

					//terminar
				};
				novascontas.Add(novaconta);
			}
			return novascontas;

		}
	}
}
