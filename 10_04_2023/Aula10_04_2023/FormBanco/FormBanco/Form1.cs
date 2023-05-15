using FormBanco.Controller;
using FormBanco.Model;

namespace FormBanco
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DateTime dataAtual = DateTime.Now;

		private void btnSave_Click(object sender, EventArgs e)
		{

			NovaConta novaconta = new NovaConta();

			novaconta.Cliente = new Cliente()
			{
				telefone = txtbTelefone.Text,
				nome = txtbNameCliente.Text,
				endereco = txtBEndereco.Text,
				dataCriado = dataAtual
			};

			novaconta.ContaCliente = new ContaCliente()
			{
				beneficioConta = txtBBeneficio.Text,
				classeConta = txtBClasseConta.Text,
				dataCriada = dataAtual,
				limite = Decimal.Parse(txtBLimite.Text),
				tipoConta = txtBTipoConta.Text
			};

			if (new FormBancoController().Inserir(novaconta))
			{
				MessageBox.Show("Registro inserido");
				CarregarGrid();
			}
			else
				MessageBox.Show("Erro ao inserir o pedido!");
		}


		private void CarregarGrid()
		{
			dgvNovaConta.DataSource = new FormBancoController().TodosOsRegistros();
		}
	}
}