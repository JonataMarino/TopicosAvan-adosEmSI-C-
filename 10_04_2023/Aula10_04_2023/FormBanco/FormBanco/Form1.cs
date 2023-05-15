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
				idCliente = int.Parse(this.lblIdCliente.Text),
				telefone = txtbTelefone.Text,
				nome = txtbNameCliente.Text,
				endereco = txtBEndereco.Text,
				dataCriado = dataAtual
			};

			novaconta.ContaCliente = new ContaCliente()
			{
				idConta = int.Parse(this.lblIdConta.Text),
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

		private bool ValidarDados(NovaConta novaconta)
		{
			if (string.IsNullOrEmpty(novaconta.Cliente.nome) || string.IsNullOrEmpty(novaconta.ContaCliente.tipoConta))
				return false;
			return true;
		}

		private void Inserir(NovaConta novaconta)
		{
			if (new FormBancoController().Inserir(novaconta))
			{
				MessageBox.Show("Registro Inserido!");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao inserir registro!");
		}

		private void Atualizar(NovaConta novaconta)
		{
			if (new FormBancoController().Atualizar(novaconta))
			{
				MessageBox.Show("Registro Atualizado");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao atualizar registro");
		}

		private void Deletar(int id)
		{
			if (new FormBancoController().Deletar(id))
			{
				MessageBox.Show("Registro Apagado");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao deletar registro");
		}

		private void ClearForm()
		{
			this.txtbNameCliente.Clear();
			this.txtbTelefone.Clear();
			this.txtBEndereco.Clear();
			this.txtBTipoConta.Clear();
			this.txtBClasseConta.Clear();
			this.txtBBeneficio.Clear();
			this.txtBLimite.Clear();
			txtbNameCliente.Focus();
		}

		private void CarregarGrid()
		{
			dgvNovaConta.DataSource = new FormBancoController().TodosOsRegistros();
		}
		public void FormBanco_Load(object sender, EventArgs e)
		{
			CarregarGrid();
		}

		private void btn_Novo_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void AtualizarConta(NovaConta novaConta)
		{
			if (new FormBancoController().Atualizar(novaConta))
			{
				MessageBox.Show("Registro Atualizado!");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao atualizar Registro");
		}


	}
}