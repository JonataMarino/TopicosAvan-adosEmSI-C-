using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBanco.Model
{
    public class ContaCliente : Conta
    {
        public decimal limite { get; set; }
        public DateTime dataCriada { get; set; }

    
    }
}
