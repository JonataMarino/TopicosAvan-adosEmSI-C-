using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBanco.Model
{
	public class ReportData
	{
        public string Nome { get; set; }
        public int IdConta { get; set; }
        public decimal Limite { get; set; }

        public List<ReportData> reportData (List<NovaConta> novaConta)
        {
            List<ReportData> lst = new List<ReportData>();
            novaConta.ForEach(novaConta =>
            {
                var rd = new ReportData
                {
                    IdConta = novaConta.ContaCliente.idConta,
                    Limite = novaConta.ContaCliente.limite,
                    Nome = novaConta.Cliente.nome
                };
                lst.Add(rd);
            });
            return lst;
        }
    }
}
