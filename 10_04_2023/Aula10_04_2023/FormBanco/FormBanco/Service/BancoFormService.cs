using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormBanco.Model;

namespace FormBanco.Service
{
	class BancoFormService
	{
		string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security = true; AttachDbFileName=D:\Logatti-7termo\TopicosAvancadosemSI\10_04_2023\bancodb.mdf;";
		SqlConnection conn;

		public BancoFormService()
		{
			conn = new SqlConnection(strCon);
			conn.Open();
		}

		public bool Inserir(NovaConta novaconta)
		{
			string strInsertConta;
			string strInsertCliente;
			
			strInsertCliente = "insert into tbl_cliente" +
				"(idcliente, nome, telefone, endereco, datacriado)" +
			"values" +
			"(@idcliente, @nome, @telefone, @endereco, @datacriado)";
			SqlCommand commandInsertCliente = new SqlCommand(strInsertCliente, conn);

			commandInsertCliente.Parameters.Add(new SqlParameter("@idcliente", novaconta.cliente.idCliente));
			commandInsertCliente.Parameters.Add(new SqlParameter("@nome", novaconta.cliente.nome));
			commandInsertCliente.Parameters.Add(new SqlParameter("@telefone", novaconta.cliente.telefone));
			commandInsertCliente.Parameters.Add(new SqlParameter("@endereco", novaconta.cliente.endereco));
			commandInsertCliente.Parameters.Add(new SqlParameter("@datacriado", novaconta.cliente.dataCriado));

			strInsertConta = "insert into tbl_conta" +
				"(idConta, tipoConta, beneficioConta, classeConta, limite, dataCriada)" +
			"values" +
			"(@idConta, @tipoConta, @beneficioConta, @classeConta, @limite, @dataCriada)";
			SqlCommand commandInsertConta = new SqlCommand(strInsertConta, conn);

			commandInsertConta.Parameters.Add(new SqlParameter("@idcliente", novaconta.conta.idConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@tipoConta", novaconta.conta.tipoConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@beneficioConta", novaconta.conta.beneficioConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@classeConta", novaconta.conta.classeConta));
			commandInsertConta.Parameters.Add(new SqlParameter("@limite", novaconta.conta.limite));
			commandInsertConta.Parameters.Add(new SqlParameter("@dataCriada", novaconta.conta.dataCriada));



			commandInsertCliente.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public List<NovaConta> TodosOsRegistros()
		{
			List<NovaConta> novascontas = new List<NovaConta>();

			StringBuilder sb = new StringBuilder();
			sb.Append("select idcliente, nome, telefone, endereco, dataCriado");
			sb.Append("idconta, tipoconta, beeneficioconta, classeconta ");
			sb.Append("numeroconta, limite, dataconta FROM tbl_cliente ");
			sb.Append("select * from tbl_conta");

			//sb.Append("Id, ");......

			/*
 Pessoa
public string nome { get; set; }
public string telefone { get; set;}
public string endereco { get; set; }

 Cliente
public int idcliente { get; set; }
public DateTime dataCriado { get; set; }
 	/*
		Conta
		public string tipoConta { get; set; }
        public string beneficioConta { get; set; }
        public string classeconta { get; set; }
		//
		public int idconta { get; set; }
		public int numeroConta { get; set; }
		public decimal limite { get; set; }
		public DateTime dataCriada { get; set; }*/


			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			SqlDataReader dr = commandSelect.ExecuteReader();

			while (dr.Read())
			{
				NovaConta novaconta = new NovaConta();


				novaconta.conta.idConta = Convert.ToInt32(dr["Id"]);
				//outros atributos

				novascontas.Add(novaconta);
			}
			return novascontas;

		}
	}
}
