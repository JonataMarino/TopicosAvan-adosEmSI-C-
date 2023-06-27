using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Petshop.Controller;
using Petshop.Model;
using Petshop.Service;

namespace Petshop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			CarregarGrid();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{

			Atendimento atendimento = new Atendimento
			{
				idAtendimento = int.Parse(this.lblIdAte.Text),
				dataAtendimento = txtBDataAte.Text,
				horaAtendimento = txtBHoraAte.Text,
				profResponsavel = txtBProf.Text,
				donoAnimal = new Dono_Animal()
				{
					idDono = int.Parse(this.lblIdProp.Text),
					nomeDono = txtBNomeProp.Text,
					endereco = txtBEndDono.Text,
					telefone = txtBTelProp.Text,
				},
				animal = new Animal()
				{
					idAnimal = int.Parse(this.lblIdAnimal.Text),
					nomeAnimal = txtbNomeAnimal.Text,
					idadeAnimal = txtBIdadeAnimal.Text,
					porteAnimal = txtBPorte.Text,
					racaAnimal = txtBRaca.Text,
				},

				baia = new Baia()
				{
					idBaia = int.Parse(this.lblIdBaia.Text),
					localBaia = txtBBaia.Text,
				},

				servico = new Servico()
				{
					idServico = int.Parse(this.lblIdServico.Text),
					descricaoServico = txtBServDesc.Text,
				}
			};

			if (new PetShopController().InserirAtendimento(atendimento))
			{
				MessageBox.Show("Registro inserido");
				CarregarGrid();
			}
			else
				MessageBox.Show("Erro ao inserir o registro!");
		}

		// BEGIN revalorar ações do grid
		private void CarregarGrid()
		{
			DgvPetShop.DataSource = new PetShopController().TodosOsRegistros();
		}

		private void formPetShop_Load(object sender, EventArgs e)
		{
			CarregarGrid();
		}

		private void DgvPetShop_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			int rowIndex = (DgvPetShop.CurrentCell.RowIndex);
			//lblIdAte.Text = DgvPetShop.Rows[rowIndex].Cells[0].Value.ToString();
			txtBNomeProp.Text = DgvPetShop.Rows[rowIndex].Cells[1].Value.ToString();
			txtBEndDono.Text = DgvPetShop.Rows[rowIndex].Cells[2].Value.ToString();
			txtBTelProp.Text = DgvPetShop.Rows[rowIndex].Cells[3].Value.ToString();
			lblIdAnimal.Text = DgvPetShop.Rows[rowIndex].Cells[4].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[5].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[6].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[7].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[8].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[9].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[10].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[11].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[12].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[13].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[14].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[15].Value.ToString();
			txtBBaia.Text = DgvPetShop.Rows[rowIndex].Cells[16].Value.ToString();



		}
		//
		private void DgvPetShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < DgvPetShop.Rows.Count)
			{
				DataGridViewRow row = DgvPetShop.Rows[e.RowIndex];
				PreencherCamposTexto(row);
			}
		}

		private void PreencherCamposTexto(DataGridViewRow row)
		{
			DgvPetShop.CellClick += DgvPetShop_CellContentClick;
		}
		//

		// Editar

		private void btnEditar_Click(object sender, EventArgs e)
		{

			int id = int.Parse(txtbExcluir.Text);


			if (id == 0)
			{
				MessageBox.Show("Selecione um atendimento");
				return;
			}
			if (id != 0)
			{
				Atendimento atendimento = new PetShopController().CarregarAtendimento(new Atendimento() { idAtendimento = id });

				//proprietário
				lblIdProp.Text = atendimento.donoAnimal.idDono.ToString();
				txtBNomeProp.Text = atendimento.donoAnimal.nomeDono.ToString();
				txtBEndDono.Text = atendimento.donoAnimal.endereco;
				txtBTelProp.Text = atendimento.donoAnimal.telefone;
				//animal
				lblIdAnimal.Text = atendimento.animal.idAnimal.ToString();
				txtbNomeAnimal.Text = atendimento.animal.nomeAnimal;
				txtBRaca.Text = atendimento.animal.racaAnimal;
				txtBPorte.Text = atendimento.animal.porteAnimal;
				txtBIdadeAnimal.Text = atendimento.animal.idadeAnimal;
				//atendimento
				lblIdAte.Text = atendimento.idAtendimento.ToString();
				txtBDataAte.Text = atendimento.dataAtendimento;
				txtBHoraAte.Text = atendimento.horaAtendimento;
				txtBProf.Text = atendimento.profResponsavel;
				//baia
				lblIdBaia.Text = atendimento.baia.idBaia.ToString();
				txtBBaia.Text = atendimento.baia.localBaia;
				//serviço
				lblIdServico.Text = atendimento.servico.idServico.ToString();
				txtBServDesc.Text = atendimento.servico.descricaoServico;

				MessageBox.Show("Atendimento Selecionado");
				return;
			}
		}

		private void btnConcluir_Click(object sender, EventArgs e)
		{
			int id = int.Parse(lblIdAte.Text);
			Atendimento atendimento = new PetShopController().AtualizarAtendimento(id);
			atendimento.idAtendimento = int.Parse(lblIdAte.Text);
			atendimento.dataAtendimento = txtBDataAte.Text;
			atendimento.horaAtendimento = txtBHoraAte.Text;
			atendimento.profResponsavel = txtBProf.Text;
			atendimento.donoAnimal.idDono = int.Parse(lblIdProp.Text);
			atendimento.donoAnimal.nomeDono = txtBNomeProp.Text;
			atendimento.donoAnimal.endereco = txtBEndDono.Text;
			atendimento.donoAnimal.telefone = txtBTelProp.Text;
			atendimento.animal.idAnimal = int.Parse(lblIdAnimal.Text);
			atendimento.animal.nomeAnimal = txtbNomeAnimal.Text;
			atendimento.animal.idadeAnimal = txtBIdadeAnimal.Text;
			atendimento.animal.porteAnimal = txtBPorte.Text;
			atendimento.animal.racaAnimal = txtBRaca.Text;
			atendimento.baia.idBaia = int.Parse(lblIdBaia.Text);
			atendimento.baia.localBaia = txtBBaia.Text;
			atendimento.servico.idServico = int.Parse(lblIdServico.Text);
			atendimento.servico.descricaoServico = txtBServDesc.Text;

			MessageBox.Show("Atendimento Atualizado");
			return;
		}



		//	Excluir
		private void ExcluirAtendimento(int id)
		{
			if (new PetShopController().ExcluirAtendimento(id))
			{
				MessageBox.Show("Atendimento Deletado");
				CarregarGrid();
			}
			else
				MessageBox.Show("Erro ao deletar atendimento");
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtbExcluir.Text);

			if (id == 0)
				MessageBox.Show("Por Favor, selecione um atendimento!");
			else
				this.ExcluirAtendimento(id);
		}
	}
}