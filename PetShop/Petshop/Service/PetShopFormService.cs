using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petshop.Model;

namespace Petshop.Service
{
	public class PetShopFormService
	{
		string strCon = @"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Logaatti-7termo\TopicosAvancadosEmSI\PetShop\Banco\DBPetShop.mdf;";
		SqlConnection conn;

		public PetShopFormService()
		{
			conn = new SqlConnection(strCon);
			conn.Open();
		}

		//resignificar querys SQL
		public bool InserirAtendimento(Atendimento atendimento)
		{
			string strInsertAtendimento;
			string strInsertAnimal;
			string strInsertBaia;
			string strInsertDonoAnimal;
			string strInsertServico;

			//insert animal
			strInsertAnimal = "insert into tbl_animal" +
				"(nomeAnimal, idadeAnimal, porteAnimal, racaAnimal)" +
			"values" +
			"(@nomeAnimal, @idadeAnimal, @porteAnimal, @racaAnimal)";

			SqlCommand commandInsertAnimal = new SqlCommand(strInsertAnimal, conn);

			commandInsertAnimal.Parameters.Add(new SqlParameter("@nomeAnimal", atendimento.animal.nomeAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@idadeAnimal", atendimento.animal.idadeAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@porteAnimal", atendimento.animal.porteAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@racaAnimal", atendimento.animal.racaAnimal));
			
			//commandInsertAnimal.ExecuteNonQuery();
			//final insert Animal

			//insert baia
			strInsertBaia = "insert into tbl_baia (localBaia) values" +
				"(@localBaia)";
			SqlCommand commandInsertBaia = new SqlCommand(strInsertBaia, conn);

			commandInsertBaia.Parameters.Add(new SqlParameter("@localBaia", atendimento.baia.localBaia));
			
			//final insert baia

			//insert dono do animal
			strInsertDonoAnimal = "insert into tbl_donoAnimal (nomeDono, endereco, telefone)" +
				"values (@nomeDono, @endereco, @telefone)";
			SqlCommand commandInsertDono = new SqlCommand(strInsertDonoAnimal, conn);

			commandInsertDono.Parameters.Add(new SqlParameter("@nomeDono", atendimento.donoAnimal.nomeDono));
			commandInsertDono.Parameters.Add(new SqlParameter("@endereco", atendimento.donoAnimal.endereco));
			commandInsertDono.Parameters.Add(new SqlParameter("@telefone", atendimento.donoAnimal.telefone));

			//final insert dono do animal

			//insert servico
			strInsertServico = "insert into tbl_servico (descricaoServico) values" +
				"(@descricaoServico)";
			SqlCommand commandInsertServico = new SqlCommand(strInsertServico, conn);

			commandInsertServico.Parameters.Add(new SqlParameter("@descricaoServico", atendimento.servico.descricaoServico));
			
		
			//final insert servico
			
			commandInsertAnimal.ExecuteNonQuery();
			commandInsertBaia.ExecuteNonQuery();
			commandInsertDono.ExecuteNonQuery();
			commandInsertServico.ExecuteNonQuery();


			//insert um Atendimento
			strInsertAtendimento = "insert into tbl_atendimento" +
				"(idDono, idBaia, idAnimal, idServico, dataAtendimento, horaAtendimento, " +
				"profResponsavel)" +
			"values" +
			"(@idDono, @idBaia, @idAnimal, @idServico, @dataAtendimento," +
			"@horaAtendimento, @profResponsavel);";
			SqlCommand commandInsertAtendimento = new SqlCommand(strInsertAtendimento, conn);
			
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idDono", atendimento.donoAnimal.idDono));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idBaia", atendimento.baia.idBaia));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idAnimal", atendimento.animal.idAnimal));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idServico", atendimento.servico.idServico));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@dataAtendimento", atendimento.dataAtendimento));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@horaAtendimento", atendimento.horaAtendimento));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@profResponsavel", atendimento.profResponsável));
			
			commandInsertAtendimento.ExecuteNonQuery();
			
			conn.Close();
			return true;
		}

		public List<Atendimento> TodosOsRegistros()
		{
			List<Atendimento> novascontas = new List<Atendimento>();

			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT atendimento.idAtendimento, " +
			"atendimento.dataAtendimento, " +
			"atendimento.horaAtendimento, " +
			"atendimento.profResponsavel, " +
			"dono.nomeDono, " +
			"baia.localBaia, " +
			"animal.nomeAnimal, " +
			"servico.descricaoServico ");
			sb.Append("FROM tbl_atendimento as atendimento ");
			sb.Append("INNER JOIN tbl_donoAnimal as dono ON atendimento.idDono = dono.idDono ");
			sb.Append("INNER JOIN tbl_baia as baia ON atendimento.idBaia = baia.idBaia ");
			sb.Append("INNER JOIN tbl_animal as animal ON atendimento.idAnimal = animal.idAnimal ");
			sb.Append("INNER JOIN tbl_servico as servico ON atendimento.IdServico = servico.idServico;");

			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			SqlDataReader dr = commandSelect.ExecuteReader();

			while (dr.Read())
			{
				Atendimento atendimento = new Atendimento()
				{

					idAtendimento = Convert.ToInt32(dr["idAtendimento"]),
					dataAtendimento = (string)(dr["dataAtendimento"]),
					horaAtendimento = (string)(dr["horaAtendimento"]),
					profResponsável = (string)(dr["profResponsavel"]),

					donoAnimal = new Dono_Animal()
					{

						idDono = Convert.ToInt32(dr["idDono"]),
						nomeDono = (string)(dr["nomeDono"]),
						telefone = (string)(dr["telefone"]),
						endereco = (string)(dr["enderecoCliente"]),
					},

					animal = new Animal()
					{
						idAnimal = Convert.ToInt32(dr["idAnimal"]),
						nomeAnimal = (string)(dr["nomeAnimal"]),
						idadeAnimal = (string)(dr["idadeAnimal"]),
						porteAnimal = (string)(dr["porteAnimal"]),
						racaAnimal = (string)(dr["racaAnimal"]),
					},

					baia = new Baia()
					{
						idBaia = Convert.ToInt32(dr["idBaia"]),
						localBaia = (string)(dr["localBaia"]),

					},

					servico = new Servico()
					{
						idServico = Convert.ToInt32(dr["idServico"]),
						descricaoServico = (string)(dr["descricaoServico"])
					},
				};

				novascontas.Add(atendimento);
			}

			return novascontas;
		}
	}
}


			/*public bool Atualizar(Atendimento atendimento)
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
		*/

/*
public bool Deletar(int id)
{
	string strInsert = "DELETE FROM TBL_CONTA WHERE idcliente IN (SELECT idcliente FROM tbl_cliente);\r\n\r\nDELETE FROM tbl_cliente;";
	SqlCommand commandInsert = new SqlCommand(strInsert, conn);
	commandInsert.Parameters.Add(new SqlParameter("id", id));

	commandInsert.ExecuteNonQuery();
	conn.Close();
	return true;
}*/

