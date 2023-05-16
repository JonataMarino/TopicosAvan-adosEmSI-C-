using System;
using System.Collections.Generic;
using System.ComponentModel;
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
			
			//Inserindo um cliente

			strInsertCliente = "insert into tbl_cliente" +
				"(nomecliente, telefoneCliente, enderecoCliente, dataCriado)" +
			"values" +
			"(@nomeCliente, @telefoneCliente, @enderecoCliente, @dataCriado); select cast(scope_identity() as int) ";
			SqlCommand commandInsertCliente = new SqlCommand(strInsertCliente, conn);

			commandInsertCliente.Parameters.Add(new SqlParameter("@nomeCliente", novaconta.Cliente.nome));
			commandInsertCliente.Parameters.Add(new SqlParameter("@telefoneCliente", novaconta.Cliente.telefone));
			commandInsertCliente.Parameters.Add(new SqlParameter("@enderecoCliente", novaconta.Cliente.endereco));
			commandInsertCliente.Parameters.Add(new SqlParameter("@dataCriado", novaconta.Cliente.dataCriado));


			int idCliente = (int) commandInsertCliente.ExecuteScalar();
			//Inserir a Conta que tem um cliente


			strInsertConta = "insert into tbl_conta" +
				"(tipoConta, beneficioConta, classeConta, contaLimite, dataCriada, idcliente)" +
			"values" +
			"(@tipoConta, @beneficioConta, @classeConta, @contaLimite, @dataCriada, @idcliente)";
		
			SqlCommand commandInsertConta = new SqlCommand(strInsertConta, conn);

			commandInsertConta.Parameters.Add(new SqlParameter("@tipoConta", novaconta.ContaCliente.tipoConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@beneficioConta", novaconta.ContaCliente.beneficioConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@classeConta", novaconta.ContaCliente.classeConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@contaLimite", novaconta.ContaCliente.limite));
			commandInsertConta.Parameters.Add(new SqlParameter("@dataCriada", novaconta.ContaCliente.dataCriada));
			commandInsertConta.Parameters.Add(new SqlParameter("@idcliente", idCliente));

			commandInsertConta.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public bool Atualizar(NovaConta novaconta)
		{
			string strUpdtConta;
			string strUpdtCliente;

			strUpdtCliente = "update tbl_cliente set nomeCliente = @nomeCliente," +
				"telefoneCliente = @telefoneCliente, enderecoCliente = @enderecoCliente" +
				"where id = @id";
			SqlCommand commandUpdtCliente = new SqlCommand(strUpdtCliente, conn);
			commandUpdtCliente.Parameters.Add(new SqlParameter("@nomeCliente", novaconta.Cliente.nome));
			commandUpdtCliente.Parameters.Add(new SqlParameter("@telefoneCliente", novaconta.Cliente.telefone));
			commandUpdtCliente.Parameters.Add(new SqlParameter("@enderecoCliente", novaconta.Cliente.endereco));
			commandUpdtCliente.ExecuteNonQuery();

			strUpdtConta = "update tbl_conta set tipoConta = @tipoConta, " +
				"beneficioConta = @beneficioConta, classeConta = @classeConta" +
				"contaLimite = @ContaLimite";
			SqlCommand CommanndUpdtConta = new SqlCommand(strUpdtConta, conn);
			CommanndUpdtConta.Parameters.Add(new SqlParameter("@tipoConta", novaconta.ContaCliente.tipoConta));
			CommanndUpdtConta.Parameters.Add(new SqlParameter("@beneficioConta", novaconta.ContaCliente.beneficioConta));
			CommanndUpdtConta.Parameters.Add(new SqlParameter("@classeConta", novaconta.ContaCliente.classeConta));
			CommanndUpdtConta.Parameters.Add(new SqlParameter("@contaLimite", novaconta.ContaCliente.limite));
			CommanndUpdtConta.ExecuteNonQuery();

			conn.Close();
			return true;
		}

		public bool Deletar(int id)
		{
			string strDeleteCliente;
			string strDeleteConta;

			strDeleteCliente = "delete from tbl_cliente where id = @id";
			SqlCommand commandDeleteCliente = new SqlCommand(strDeleteCliente, conn);
			commandDeleteCliente.ExecuteNonQuery();
			strDeleteConta = "delete from tbl_conta where id = @id";
			SqlCommand commandDeleteConta = new SqlCommand(strDeleteCliente, conn);
			commandDeleteConta.ExecuteNonQuery();
			conn.Close();
			return true;

		}

		public NovaConta ConsultarPorId(int id)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT cliente.idcliente, ");
			sb.Append("		  cliente.nomeCliente, ");
			sb.Append("		  cliente.telefoneCliente, ");
			sb.Append("		  cliente.enderecoCliente, ");
			sb.Append("		  cliente.dataCriado");
			sb.Append("		  cliente.nomeCliente");
			sb.Append(" 	  conta.idConta,");
			sb.Append(" 	  conta.tipoConta, ");
			sb.Append(" 	  conta.beneficioConta, ");
			sb.Append(" 	  conta.classeConta, ");
			sb.Append(" 	  conta.contaLimite, ");
			sb.Append(" 	  conta.dataCriada ");
			sb.Append(" FROM tbl_cliente cliente left join TBL_CONTA conta ");
			sb.Append("   on cliente.idcliente = conta.idcliente ");

			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			commandSelect.Parameters.Add(new SqlParameter("@id", id));

			SqlDataReader dr = commandSelect.ExecuteReader();


			NovaConta novaConta = new NovaConta();

			if (dr.Read())
			{
				novaConta.Cliente = new Cliente()
				{
					idCliente = Convert.ToInt32(dr["idcliente"]),
					nome = (string)dr["nomeCliente"],
					telefone = (string)dr["telefoneCliente"],
					endereco = (string)dr["enderecoCliente"],
					dataCriado = DateTime.Parse((string)dr["dataCriado"])
				};
				novaConta.ContaCliente = new ContaCliente()
				{
					idConta = Convert.ToInt32(dr["idConta"]),
					tipoConta = (string)dr["tipoConta"],
					classeConta = (string)dr["classeConta"],
					beneficioConta = (string)dr["beneficioConta"],
					limite = decimal.Parse((string)dr["contaLimite"])
				};
			}
			return novaConta;
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
					dataCriado = (DateTime)dr["dataCriado"]
				};

				var idConta = (int)dr["idConta"];
				var tipoConta = (string)dr["tipoConta"];
				var classeConta = (string)dr["classeConta"];
				var beneficioConta = (string)dr["beneficioConta"];
				var limite = (decimal)dr["contaLimite"];

				novaconta.ContaCliente = new ContaCliente()
				{
					idConta = idConta,
				tipoConta = tipoConta,
				classeConta = classeConta,
				beneficioConta = beneficioConta,
				limite = limite
				};
				novascontas.Add(novaconta);
			}
			return novascontas;

		}
	}
}
