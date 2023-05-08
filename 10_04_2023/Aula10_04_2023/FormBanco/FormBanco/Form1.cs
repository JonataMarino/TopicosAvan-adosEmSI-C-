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
			novaconta.cliente.nome = txtbNameCliente.Text;
			novaconta.cliente.telefone = txtbTelefone.Text;
			novaconta.cliente.endereco = txtBEndereco.Text;
			novaconta.cliente.dataCriado = dataAtual;
			novaconta.conta.tipoConta = txtBTipoConta.Text;
			novaconta.conta.classeConta = txtBClasseConta.Text;
			novaconta.conta.beneficioConta = txtBBeneficio.Text;
			novaconta.conta.limite = (decimal)float.Parse(txtBLimite.Text);
			/* Gerar um novo objeto em uma nova ação do forms? */
			ContaCliente contaCliente = new ContaCliente()
			{
				tipoConta = txtBTipoConta.Text,
				classeConta = txtBClasseConta.Text,
				beneficioConta = txtBBeneficio.Text,
				limite = (decimal)float.Parse(txtBLimite.Text),

			};
			if (new FormBancoController().Inserir(novaconta){
				MessageBox.Show("Regsitro inserido");
				//Carregargrid()
			}
			else
			{
				MessageBox.Show("Erro ao inserir o pedido!");

				/*Private void carregarGrid()
				{
					dgv.DataSource.DataSouce = new FormBancoController().TodosOsRegistros();
				}*/
			}

		}
	}