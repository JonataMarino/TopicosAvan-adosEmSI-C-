﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20_03_2023
{
	public class CP : Account
	{
		public decimal saldo { get; set; }
		public int TimeStep { get; set; }
		public double TxInterest { get; set; }
	}
}