using Petshop.Controller;
using Petshop.Model;

namespace Petshop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// BEGIN revalorar ações do grid
		private void CarregarGrid()
		{
			DgvPetShop.DataSource = new PetShopController().TodosOsRegistros();
		}

		private void frmAgenda_Load(object sender, EventArgs e)
		{
			CarregarGrid();
		}

		private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = (DgvPetShop.CurrentCell.RowIndex);
			lblIdAte.Text = DgvPetShop.Rows[rowIndex].Cells[0].Value.ToString();
			txtbNomeAnimal.Text = DgvPetShop.Rows[rowIndex].Cells[1].Value.ToString();
			txtBNomeProp.Text = DgvPetShop.Rows[rowIndex].Cells[2].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[3].Value.ToString();
		}
		//revalorar ações do grid END
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Atendimento atendimento = new Atendimento()
			{
				idAtendimento = int.Parse(this.lblIdAte.Text),
				dataAtendimento = txtBDataAte.Text,
				horaAtendimento = txtBHoraAte.Text,
				profResponsável = txtBProf.Text,
			};


			atendimento.donoAnimal = new Dono_Animal()
			{
				idDono = int.Parse(this.lblDono.Text),
				nomeDono = txtBNomeProp.Text,
				endereco = txtBEndDono.Text,
				telefone = txtBTelProp.Text,
			};

			atendimento.animal = new Animal()
			{
				idAnimal = int.Parse(this.lblAnimal.Text),
				nomeAnimal = txtbNomeAnimal.Text,
				idadeAnimal = txtBIdadeAnimal.Text,
				porteAnimal = txtBPorte.Text,
			};
			atendimento.baia = new Baia()
			{
				idBaia = int.Parse(this.lblIdBaia.Text),
				localBaia = txtBBaia.Text,
			};

			atendimento.servico = new Servico()
			{
				idServico = int.Parse(this.lblDataAte.Text),
				descricaoServico = txtBServDesc.Text,
			};

			if (new PetShopController().Inserir(atendimento))
			{
				MessageBox.Show("Registro inserido");
				CarregarGrid();
			}
			else
				MessageBox.Show("Erro ao inserir o pedido!");
		}
	}
}

