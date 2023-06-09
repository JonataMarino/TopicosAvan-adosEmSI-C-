using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Model;

namespace Petshop.Service
{
	class PetShopFormService
	{
		string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security = true; AttachDbFileName=D:\Logaatti-7termo\TopicosAvancadosEmSI\PetShop\DBPetShop.mdf;";
		SqlConnection conn;

		public PetShopFormService()
		{
			conn = new SqlConnection(strCon);
			conn.Open();
		}

		//resignificar querys SQL
		public bool InserirCliente(Atendimento atendimento)
		{
			string strInsertAtendimento;
			string strInsertAnimal;
			string strInsertBaia;
			string strInsertDonoAnimal;
			string strInsertServico;

			//Inserindo um Atendimento

			strInsertAtendimento = "insert into tbl_atendimento" +
				"(idDono, idBaia, idAnimal, IdServico, dataAtendimento, horaAtendimento" +
				"profResponsavel)" +
			"values" +
			"(@idDono, @idBaia, @idAnimal, @idServico, @dataAtendimento," +
			"@horaAtendimento, @profResponsavel); select cast(scope_identity() as int) ";
			SqlCommand commandInsertAtendimento = new SqlCommand(strInsertAtendimento, conn);

			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idDono", atendimento.donoAnimal.idDono));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idAnimal", atendimento.animal.idAnimal));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idServico", atendimento.servico.idServico));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idBaia", atendimento.baia.idBaia));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@dataAtendimento", atendimento.dataAtendimento));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@horaAtendimento", atendimento.horaAtendimento));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@profResponsavel", atendimento.profResponsável));


			int idAtendimento = (int)commandInsertAtendimento.ExecuteScalar();
			//final Inserir Atendimento

			//inserir Animal
			strInsertAnimal = "insert into tbl_animal" +
				"(idAnimal, nomeAnimal, idadeAnimal, porteAnimal, racaAnimal)" +
			"values" +
			"(@idAnimal, @nomeAnimal, @idadeAnimal, @porteAnimal, @racaAnimal)";

			SqlCommand commandInsertAnimal = new SqlCommand(strInsertAnimal, conn);

			commandInsertAnimal.Parameters.Add(new SqlParameter("@idAnimal", atendimento.animal.idAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@nomeAnimal", atendimento.animal.nomeAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@idadeAnimal", atendimento.animal.idadeAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@porteAnimal", atendimento.animal.porteAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@racaAnimal", atendimento.animal.racaAnimal));
			
			commandInsertAnimal.ExecuteNonQuery();
			// final inserir animal


			conn.Close();
			return true;
		}

		public bool Atualizar(Atendimento atendimento)
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

		/*		public bool Deletar(int id)
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
		*/
		public Atendimento ConsultarPorId(int id)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT cliente.idcliente, ");
			

			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			commandSelect.Parameters.Add(new SqlParameter("@id", id));

			SqlDataReader dr = commandSelect.ExecuteReader();


			Atendimento atendimento = new Atendimento();

			if (dr.Read())
			{
				atendimento.animal = new Animal()
				{
					//revalorar atributos
					idCliente = Convert.ToInt32(dr["idcliente"]),
					nome = (string)dr["nomeCliente"],
					telefone = (string)dr["telefoneCliente"],
					endereco = (string)dr["enderecoCliente"],
					dataCriado = DateTime.Parse((string)dr["dataCriado"])
				};
				//resignificar pesquisas SQL
				atendimento. = new ContaCliente()
				{
					idConta = Convert.ToInt32(dr["idConta"]),
					tipoConta = (string)dr["tipoConta"],
					classeConta = (string)dr["classeConta"],
					beneficioConta = (string)dr["beneficioConta"],
					limite = decimal.Parse((string)dr["contaLimite"])
				};
			}
			return atendimento;
		}

		public List<Atendimento> TodosOsRegistros()
		{
			List<Atendimento> novascontas = new List<Atendimento>();

			StringBuilder sb = new StringBuilder();

			sb.Append(" SELECT cliente.idcliente, ");



			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			SqlDataReader dr = commandSelect.ExecuteReader();

			while (dr.Read())
			{
				Atendimento atendimento = new Atendimento();

				atendimento.donoAnimal = new Dono_Animal()
				{
					//revalorar atributos
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

		public bool Deletar(int id)
		{
			string strInsert = "DELETE FROM TBL_CONTA WHERE idcliente IN (SELECT idcliente FROM tbl_cliente);\r\n\r\nDELETE FROM tbl_cliente;";
			SqlCommand commandInsert = new SqlCommand(strInsert, conn);
			commandInsert.Parameters.Add(new SqlParameter("id", id));

			commandInsert.ExecuteNonQuery();
			conn.Close();
			return true;
		}
	}
}
