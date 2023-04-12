using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03_04_2023
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Calcular_Click(object sender, EventArgs e)
		{
			double a = double.Parse(boxValorA.Text);
			double b = double.Parse(boxValorB.Text);
			double c = double.Parse(boxValorC.Text);

			double delta1 = Math.Sqrt(b*b);
			double delta2 = Math.Sqrt(4*a*c);

			double delta = (delta1 - delta2);

			double x1 = (-b + (delta)) / (2 * a);
			double x2 = (-b - (delta)) / (2 * a);

			MessageBox.Show($"Valor de Delta: {delta}\nX2: {x2}\nX1: {x1}");
		}

		private void btnIMC_Click(object sender, EventArgs e)
		{
			float peso = float.Parse(boxPeso.Text);
			float altura = float.Parse(boxAltura.Text);

			float imc = peso / (altura * altura);

			if (imc > 18.5 && imc < 24.9)
				MessageBox.Show($"Seu IMC é {imc} e está abaixo dp recomendado");
			else if (imc > 24.9 && imc < 29.9)
				MessageBox.Show($"Seu IMC é {imc} e é considerado um valor normal");
			else if (imc > 29.9 && imc <34.99)
				MessageBox.Show($"Seu IMC é {imc} e você pode estar com sobrepeso");

		}
	}
}
