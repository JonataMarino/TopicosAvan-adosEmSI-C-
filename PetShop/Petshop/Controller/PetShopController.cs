using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Controller
{
	class PetShopController
	{
		string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security = true; AttachDbFileName=D:\Logaatti-7termo\TopicosAvancadosEmSI\PetShop\DBPetShop.mdf;";
		SqlConnection conn;
		public PetShopController() { 
			conn = new SqlConnection(strCon);
			conn.Open();
		}

	}
}
