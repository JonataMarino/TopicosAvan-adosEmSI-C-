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
			"(@nomeAnimal, @idadeAnimal, @porteAnimal, @racaAnimal); SELECT SCOPE_IDENTITY()";

			SqlCommand commandInsertAnimal = new SqlCommand(strInsertAnimal, conn);

			commandInsertAnimal.Parameters.Add(new SqlParameter("@nomeAnimal", atendimento.animal.nomeAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@idadeAnimal", atendimento.animal.idadeAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@porteAnimal", atendimento.animal.porteAnimal));
			commandInsertAnimal.Parameters.Add(new SqlParameter("@racaAnimal", atendimento.animal.racaAnimal));

			int idAnimal = Convert.ToInt32(commandInsertAnimal.ExecuteScalar());

			//insert baia
			strInsertBaia = "insert into tbl_baia (localBaia) values" +
				"(@localBaia) ; SELECT SCOPE_IDENTITY()";
			SqlCommand commandInsertBaia = new SqlCommand(strInsertBaia, conn);

			commandInsertBaia.Parameters.Add(new SqlParameter("@localBaia", atendimento.baia.localBaia));
			int idBaia = Convert.ToInt32(commandInsertBaia.ExecuteScalar());

			//final insert baia

			//insert dono do animal
			strInsertDonoAnimal = "insert into tbl_donoAnimal (nomeDono, endereco, telefone)" +
				"values (@nomeDono, @endereco, @telefone); SELECT SCOPE_IDENTITY()";
			SqlCommand commandInsertDono = new SqlCommand(strInsertDonoAnimal, conn);

			commandInsertDono.Parameters.Add(new SqlParameter("@nomeDono", atendimento.donoAnimal.nomeDono));
			commandInsertDono.Parameters.Add(new SqlParameter("@endereco", atendimento.donoAnimal.endereco));
			commandInsertDono.Parameters.Add(new SqlParameter("@telefone", atendimento.donoAnimal.telefone));
			int idDono = Convert.ToInt32(commandInsertDono.ExecuteScalar());
			//final insert dono do animal

			//insert servico
			strInsertServico = "insert into tbl_servico (descricaoServico) values" +
				"(@descricaoServico); SELECT SCOPE_IDENTITY()";
			SqlCommand commandInsertServico = new SqlCommand(strInsertServico, conn);

			commandInsertServico.Parameters.Add(new SqlParameter("@descricaoServico", atendimento.servico.descricaoServico));
			int idServico = Convert.ToInt32(commandInsertServico.ExecuteScalar());


			//insert um Atendimento

			strInsertAtendimento = "INSERT INTO tbl_atendimento (idDono, idBaia, idAnimal, idServico, dataAtendimento, horaAtendimento, profResponsavel) " +
					  "VALUES (@idDono, @idBaia, @idAnimal, @idServico, @dataAtendimento, @horaAtendimento, @profResponsavel);";
			SqlCommand commandInsertAtendimento = new SqlCommand(strInsertAtendimento, conn);


			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idDono", idDono));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idBaia", idBaia));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idAnimal", idAnimal));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@idServico", idServico));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@dataAtendimento", atendimento.dataAtendimento));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@horaAtendimento", atendimento.horaAtendimento));
			commandInsertAtendimento.Parameters.Add(new SqlParameter("@profResponsavel", atendimento.profResponsável));

			commandInsertAtendimento.ExecuteNonQuery();

			conn.Close();
			return true;
		}

		public List<Atendimento> TodosOsRegistros()
		{
			List<Atendimento> atendimentos = new List<Atendimento>();
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
						nomeDono = (string)(dr["nomeDono"]),
					},

					animal = new Animal()
					{
						nomeAnimal = (string)(dr["nomeAnimal"]),
					},

					baia = new Baia()
					{
						localBaia = (string)(dr["localBaia"]),

					},

					servico = new Servico()
					{
						descricaoServico = (string)(dr["descricaoServico"])
					},
				};

				atendimentos.Add(atendimento);
			}

			return atendimentos;
		}

		public Atendimento CarregarAtendimento(Atendimento atendimento)
		{
			List<Atendimento> atd = new List<Atendimento>();
			StringBuilder sb = new StringBuilder();

			sb.Append("SELECT atendimento.idAtendimento, atendimento.dataAtendimento, " +
				"atendimento.horaAtendimento, atendimento.profResponsavel, " +
				 "animal.idAnimal, animal.nomeAnimal, animal.idadeAnimal, " +
				"animal.porteAnimal, animal.racaAnimal, baia.idBaia, baia.localBaia, " +
				"dono.idDono, dono.nomeDono, dono.endereco, dono.telefone, " +
				"servico.idServico, servico.descricaoServico " +
			"FROM tbl_atendimento as atendimento " +
			"JOIN tbl_donoAnimal as dono ON atendimento.idDono = dono.idDono " +
			"JOIN tbl_baia as baia ON atendimento.idBaia = baia.idBaia " +
			"JOIN tbl_animal as animal ON atendimento.idAnimal = animal.idAnimal " +
			"JOIN tbl_servico as servico ON atendimento.idServico = servico.idServico " +
			"WHERE idAtendimento = @idAtendimento;");

			SqlCommand commandSelectOne = new SqlCommand(sb.ToString(), conn);
			commandSelectOne.Parameters.Add(new SqlParameter("@idAtendimento", atendimento.idAtendimento));
			SqlDataReader dr = commandSelectOne.ExecuteReader();

			if (dr.Read())
			{
				Atendimento at = new Atendimento()
				{
					idAtendimento = Convert.ToInt32(dr["idAtendimento"]),
					dataAtendimento = (string)(dr["dataAtendimento"]),
					horaAtendimento = (string)(dr["horaAtendimento"]),
					profResponsável = (string)(dr["profResponsavel"]),

					donoAnimal = new Dono_Animal()
					{
						idDono = Convert.ToInt32(dr["idDono"]),
						nomeDono = (string)(dr["nomeDono"]),
						endereco = (string)(dr["endereco"]),
						telefone = (string)(dr["telefone"]),
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
						localBaia = (string)(dr["localBaia"]),

					},

					servico = new Servico()
					{
						descricaoServico = (string)(dr["descricaoServico"])
					},
				};
				return at;
			}
			return null;
		}
		
		
		public bool AtualizarAtendimento(Atendimento atendimento)
		{
			string strUpdtAtendimento;
			string strUpdtAnimal;
			string strUpdtBaia;
			string strUpdtDonoAnimal;
			string strUpdtServico;

			strUpdtAtendimento = "update tbl_atendimento set dataAtendimento = @dataAtendimento," +
				"horaAtendimento = @horaAtendimento, profResponsavel = @profResponsavel " +
				"where idAtendimento = @idAtendimento";
			SqlCommand commandUpdtAtendimento = new SqlCommand(strUpdtAtendimento, conn);
			commandUpdtAtendimento.Parameters.Add(new SqlParameter("@idAtendimento", atendimento.idAtendimento));
			commandUpdtAtendimento.Parameters.Add(new SqlParameter("@dataAtendimento", atendimento.dataAtendimento));
			commandUpdtAtendimento.Parameters.Add(new SqlParameter("@horaAtendimento", atendimento.horaAtendimento));
			commandUpdtAtendimento.Parameters.Add(new SqlParameter("@profResponsavel", atendimento.profResponsável));
			commandUpdtAtendimento.ExecuteNonQuery();

			strUpdtDonoAnimal = "update tbl_donoAnimal set nomeDono = @nomeDono, endereco = @endereco, telefone = @telefone where idDono = @idDono";
			SqlCommand CommandUpdtDonoAnimal = new SqlCommand(strUpdtDonoAnimal, conn);
			CommandUpdtDonoAnimal.Parameters.Add(new SqlParameter("@nomeDono", atendimento.donoAnimal.nomeDono));
			CommandUpdtDonoAnimal.Parameters.Add(new SqlParameter("@endereco", atendimento.donoAnimal.endereco));
			CommandUpdtDonoAnimal.Parameters.Add(new SqlParameter("@telefone", atendimento.donoAnimal.telefone));
			CommandUpdtDonoAnimal.Parameters.Add(new SqlParameter("@idDono", atendimento.donoAnimal.idDono));
			CommandUpdtDonoAnimal.ExecuteNonQuery();

			strUpdtBaia = "update tbl_baia set localBaia = @localBaia where idBaia = @idBaia";
			SqlCommand CommandUpdtBaia = new SqlCommand(strUpdtBaia, conn);
			CommandUpdtBaia.Parameters.Add(new SqlParameter("@localBaia", atendimento.baia.localBaia));
			CommandUpdtBaia.Parameters.Add(new SqlParameter("@IdBaia", atendimento.baia.idBaia));
			CommandUpdtBaia.ExecuteNonQuery();

			strUpdtAnimal = "update tbl_animal set nomeAnimal = @nomeAnimal, idadeAnimal = @idadeAnimal, porteAnimal = @porteAnimal, racaAnimal = @racaAnimal " +
				"where idAnimal = @idAnimal";
			SqlCommand CommandUpdtAnimal = new SqlCommand(strUpdtAnimal, conn);
			CommandUpdtAnimal.Parameters.Add(new SqlParameter("@idAnimal", atendimento.animal.idAnimal));
			CommandUpdtAnimal.Parameters.Add(new SqlParameter("@idadeAnimal", atendimento.animal.idadeAnimal));
			CommandUpdtAnimal.Parameters.Add(new SqlParameter("@porteAnimal", atendimento.animal.porteAnimal));
			CommandUpdtAnimal.Parameters.Add(new SqlParameter("@racaAnimal", atendimento.animal.racaAnimal));
			CommandUpdtAnimal.Parameters.Add(new SqlParameter("@nomeAnimal", atendimento.animal.nomeAnimal));
			CommandUpdtAnimal.ExecuteNonQuery();


			strUpdtServico = "update tbl_servico set descricaoservico = @descricaoServico where idServico = @idServico";
			SqlCommand CommandUpdtServico = new SqlCommand(strUpdtServico, conn);
			CommandUpdtServico.Parameters.Add(new SqlParameter("@idServico", atendimento.servico.idServico));
			CommandUpdtServico.Parameters.Add(new SqlParameter("@descricaoServico", atendimento.servico.descricaoServico));
			CommandUpdtServico.ExecuteNonQuery();

			conn.Close();
			return true;
		}
		public bool ExcluirAtendimento(int id)
		{

			string strDeleteAtendimento = "DELETE FROM tbl_atendimento WHERE idAtendimento = @idAtendimento";
			string strDeleteAnimal = "DELETE FROM tbl_animal WHERE idAnimal IN (SELECT idAnimal FROM tbl_atendimento WHERE idAtendimento = @idAtendimento)";
			string strDeleteBaia = "DELETE FROM tbl_baia WHERE idBaia IN (SELECT idBaia FROM tbl_atendimento WHERE idAtendimento = @idAtendimento)";
			string strDeleteDono = "DELETE FROM tbl_donoAnimal WHERE idDono IN (SELECT idDono FROM tbl_atendimento WHERE idAtendimento = @idAtendimento)";
			string strDeleteServico = "DELETE FROM tbl_servico WHERE idServico IN (SELECT idServico FROM tbl_atendimento WHERE idAtendimento = @idAtendimento)";

			SqlCommand commandDeleteAnimal = new SqlCommand(strDeleteAnimal, conn);
			SqlCommand commandDeleteBaia = new SqlCommand(strDeleteBaia, conn);
			SqlCommand commandDeleteDono = new SqlCommand(strDeleteDono, conn);
			SqlCommand commandDeleteServico = new SqlCommand(strDeleteServico, conn);
			SqlCommand commandDeleteAtendimento = new SqlCommand(strDeleteAtendimento, conn);

			commandDeleteAtendimento.Parameters.Add(new SqlParameter("@idAtendimento", id));
			commandDeleteAnimal.Parameters.Add(new SqlParameter("@idAtendimento", id));
			commandDeleteBaia.Parameters.Add(new SqlParameter("@idAtendimento", id));
			commandDeleteDono.Parameters.Add(new SqlParameter("@idAtendimento", id));
			commandDeleteServico.Parameters.Add(new SqlParameter("@idAtendimento", id));
			
			commandDeleteAtendimento.ExecuteNonQuery();
			commandDeleteAnimal.ExecuteNonQuery();
			commandDeleteBaia.ExecuteNonQuery();
			commandDeleteDono.ExecuteNonQuery();
			commandDeleteServico.ExecuteNonQuery();
	
			conn.Close();
			return true;
		}
	}
}