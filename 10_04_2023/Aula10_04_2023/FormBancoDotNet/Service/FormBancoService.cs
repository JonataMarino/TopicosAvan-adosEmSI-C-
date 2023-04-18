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
		string strInsert = "insert into clienteAcc (Id, Name, Telephone, Adress) values (@Nome, @Telephone, @Adress)";
		SqlCommand commandInsert = new SqlCommand(strInsert, conn);
		StringBuilder sb = new StringBuilder();
			commandInsert.Parameters.Add(new SqlParameter("@Nome", clientacc.Client.Name));
			commandInsert.Parameters.Add(new SqlParameter("@Telephone", clientacc.Client.Telephone));
			commandInsert.Parameters.Add(new SqlParameter("@Adress", clientacc.Client.Adress));

			commandInsert.ExecuteNonQuery();
		conn.Close();
		return true;
	}

	public List<ClientAcc> TodosOsClientes()
	{
		List<ClientAcc> contasclientes = new List<ClientAcc>();

		StringBuilder sb = new StringBuilder();
		sb.Append("SELECT Id, ");
		sb.Append("       Nome, ");
		sb.Append("       Telefone ");
		sb.Append("  FROM Agenda");

		SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
		SqlDataReader dr = commandSelect.ExecuteReader();

		while (dr.Read())
		{
			ClientAcc clientacc = new ClientAcc();

			clientacc.Client.Id = Convert.ToInt32(dr["Id"]);
			clientacc.Client.Name = dr["Name"].ToString();
			clientacc.Client.Telephone = dr["Telephone"].ToString();
			contasclientes.Add(clientacc);
		}
		return agendas;
	}

}
}