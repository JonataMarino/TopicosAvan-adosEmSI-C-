using System.ComponentModel;
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

			var idCliente = int.Parse(this.lblIdConta.Text);
			var telefone = txtbTelefone.Text;
			var nome = txtbNameCliente.Text;
			var endereco = txtBEndereco.Text;
			var dataCriado = DateTime.Now;


			novaconta.Cliente = new Cliente()
			{
				idCliente = idCliente,
				telefone = telefone,
				nome = nome,
				endereco = endereco,
				dataCriado = dataCriado,
			};

			var idConta = int.Parse(this.lblIdCliente.Text);
			var beneficioConta = txtBBeneficio.Text;
			var classeConta = txtBClasseConta.Text;
			var dataCriada = dataAtual;
			var limite = Decimal.Parse(txtBLimite.Text);
			var tipoConta = txtBTipoConta.Text;

			novaconta.ContaCliente = new ContaCliente()
			{
				idConta = idConta,
				beneficioConta = beneficioConta,
				classeConta = classeConta,
				dataCriada = dataCriada,
				limite = limite,
				tipoConta = tipoConta
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
			dgvNovaConta.DataSource = new ReportData().reportData(new FormBancoController().TodosOsRegistros());
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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btn_Excluir_Click(object sender, EventArgs e)
		{
			//Deletar(id);
		}
	}
}