using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoDotNet.Service
{
	 class FormBancoService { 
	 //Implementar a conexao
		string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=D:\Logaatti-7termo\TopicosAvancadosEmSI\10_04_2023\Aula10_04_2023\Bancodb.mdf;";
	SqlConnection conn;

	public FormBancoService()
	{
		//Abertua da conexao
		conn = new SqlConnection(strCon);
		conn.Open();
	}

	public bool Inserir(ClientAcc clientacc)
	{
		//Implementar
		string strInsert = "insert into Agenda (Id, Telefone) values (@Nome, @Telefone)";
		SqlCommand commandInsert = new SqlCommand(strInsert, conn);
		StringBuilder sb = new StringBuilder();
			commandInsert.Parameters.Add(new SqlParameter("@Nome", agenda.Nome));
		commandInsert.Parameters.Add(new SqlParameter("@Telefone", agenda.Telefone));

		commandInsert.ExecuteNonQuery();
		conn.Close();
		return true;
	}

	public List<Agenda> TodosOsRegistros()
	{
		List<Agenda> agendas = new List<Agenda>();

		StringBuilder sb = new StringBuilder();
		sb.Append("SELECT Id, ");
		sb.Append("       Nome, ");
		sb.Append("       Telefone ");
		sb.Append("  FROM Agenda");

		SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
		SqlDataReader dr = commandSelect.ExecuteReader();

		while (dr.Read())
		{
			Agenda agenda = new Agenda();

			agenda.Id = Convert.ToInt32(dr["Id"]);
			agenda.Nome = dr["Nome"].ToString();
			agenda.Telefone = dr["Telefone"].ToString();
			agendas.Add(agenda);
		}
		return agendas;
	}

}
}