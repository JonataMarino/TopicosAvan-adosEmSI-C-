namespace Petshop
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtBNomeProp = new TextBox();
			txtBEndDono = new TextBox();
			txtBTelProp = new TextBox();
			lblDono = new Label();
			lblEndDono = new Label();
			lblTelDono = new Label();
			lblAnimal = new Label();
			txtbNomeAnimal = new TextBox();
			txtBRaca = new TextBox();
			txtBPorte = new TextBox();
			lblNomeAnimal = new Label();
			lblRaca = new Label();
			lblPorte = new Label();
			lblAtendimento = new Label();
			txtBProf = new TextBox();
			txtBHoraAte = new TextBox();
			txtBDataAte = new TextBox();
			lblDataAte = new Label();
			lblHoraAte = new Label();
			lblProf = new Label();
			lblServ = new Label();
			txtBServDesc = new TextBox();
			DgvPetShop = new DataGridView();
			lblIdadeAn = new Label();
			txtBIdadeAnimal = new TextBox();
			lblIdProp = new Label();
			lblIdAte = new Label();
			lblIdServico = new Label();
			lblIdAnimal = new Label();
			btnSalvar = new Button();
			btnEditar = new Button();
			btnExcluir = new Button();
			txtBBaia = new TextBox();
			lblBaia = new Label();
			lblIdBaia = new Label();
			((System.ComponentModel.ISupportInitialize)DgvPetShop).BeginInit();
			SuspendLayout();
			// 
			// txtBNomeProp
			// 
			txtBNomeProp.Location = new Point(1, 39);
			txtBNomeProp.Name = "txtBNomeProp";
			txtBNomeProp.Size = new Size(213, 23);
			txtBNomeProp.TabIndex = 0;
			// 
			// txtBEndDono
			// 
			txtBEndDono.Location = new Point(1, 83);
			txtBEndDono.Name = "txtBEndDono";
			txtBEndDono.Size = new Size(213, 23);
			txtBEndDono.TabIndex = 1;
			// 
			// txtBTelProp
			// 
			txtBTelProp.Location = new Point(1, 127);
			txtBTelProp.Name = "txtBTelProp";
			txtBTelProp.Size = new Size(213, 23);
			txtBTelProp.TabIndex = 2;
			// 
			// lblDono
			// 
			lblDono.AutoSize = true;
			lblDono.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblDono.Location = new Point(12, 9);
			lblDono.Name = "lblDono";
			lblDono.Size = new Size(192, 25);
			lblDono.TabIndex = 3;
			lblDono.Text = "Proprietário do Animal";
			// 
			// lblEndDono
			// 
			lblEndDono.AutoSize = true;
			lblEndDono.Location = new Point(1, 65);
			lblEndDono.Name = "lblEndDono";
			lblEndDono.Size = new Size(56, 15);
			lblEndDono.TabIndex = 4;
			lblEndDono.Text = "Endereço";
			// 
			// lblTelDono
			// 
			lblTelDono.AutoSize = true;
			lblTelDono.Location = new Point(1, 109);
			lblTelDono.Name = "lblTelDono";
			lblTelDono.Size = new Size(51, 15);
			lblTelDono.TabIndex = 5;
			lblTelDono.Text = "Telefone";
			// 
			// lblAnimal
			// 
			lblAnimal.AutoSize = true;
			lblAnimal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblAnimal.Location = new Point(69, 151);
			lblAnimal.Name = "lblAnimal";
			lblAnimal.Size = new Size(67, 25);
			lblAnimal.TabIndex = 6;
			lblAnimal.Text = "Animal";
			// 
			// txtbNomeAnimal
			// 
			txtbNomeAnimal.Location = new Point(1, 179);
			txtbNomeAnimal.Name = "txtbNomeAnimal";
			txtbNomeAnimal.Size = new Size(213, 23);
			txtbNomeAnimal.TabIndex = 7;
			// 
			// txtBRaca
			// 
			txtBRaca.Location = new Point(1, 226);
			txtBRaca.Name = "txtBRaca";
			txtBRaca.Size = new Size(213, 23);
			txtBRaca.TabIndex = 8;
			// 
			// txtBPorte
			// 
			txtBPorte.Location = new Point(1, 270);
			txtBPorte.Name = "txtBPorte";
			txtBPorte.Size = new Size(213, 23);
			txtBPorte.TabIndex = 9;
			// 
			// lblNomeAnimal
			// 
			lblNomeAnimal.AutoSize = true;
			lblNomeAnimal.Location = new Point(1, 161);
			lblNomeAnimal.Name = "lblNomeAnimal";
			lblNomeAnimal.Size = new Size(40, 15);
			lblNomeAnimal.TabIndex = 10;
			lblNomeAnimal.Text = "Nome";
			// 
			// lblRaca
			// 
			lblRaca.AutoSize = true;
			lblRaca.Location = new Point(1, 208);
			lblRaca.Name = "lblRaca";
			lblRaca.Size = new Size(32, 15);
			lblRaca.TabIndex = 11;
			lblRaca.Text = "Raça";
			// 
			// lblPorte
			// 
			lblPorte.AutoSize = true;
			lblPorte.Location = new Point(1, 252);
			lblPorte.Name = "lblPorte";
			lblPorte.Size = new Size(35, 15);
			lblPorte.TabIndex = 12;
			lblPorte.Text = "Porte";
			// 
			// lblAtendimento
			// 
			lblAtendimento.AutoSize = true;
			lblAtendimento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblAtendimento.Location = new Point(287, 9);
			lblAtendimento.Name = "lblAtendimento";
			lblAtendimento.Size = new Size(116, 25);
			lblAtendimento.TabIndex = 13;
			lblAtendimento.Text = "Atendimento";
			// 
			// txtBProf
			// 
			txtBProf.Location = new Point(246, 151);
			txtBProf.Name = "txtBProf";
			txtBProf.Size = new Size(213, 23);
			txtBProf.TabIndex = 16;
			// 
			// txtBHoraAte
			// 
			txtBHoraAte.Location = new Point(246, 101);
			txtBHoraAte.Name = "txtBHoraAte";
			txtBHoraAte.Size = new Size(213, 23);
			txtBHoraAte.TabIndex = 15;
			// 
			// txtBDataAte
			// 
			txtBDataAte.Location = new Point(246, 48);
			txtBDataAte.Name = "txtBDataAte";
			txtBDataAte.Size = new Size(213, 23);
			txtBDataAte.TabIndex = 14;
			// 
			// lblDataAte
			// 
			lblDataAte.AutoSize = true;
			lblDataAte.Location = new Point(250, 30);
			lblDataAte.Name = "lblDataAte";
			lblDataAte.Size = new Size(31, 15);
			lblDataAte.TabIndex = 17;
			lblDataAte.Text = "Data";
			// 
			// lblHoraAte
			// 
			lblHoraAte.AutoSize = true;
			lblHoraAte.Location = new Point(246, 83);
			lblHoraAte.Name = "lblHoraAte";
			lblHoraAte.Size = new Size(121, 15);
			lblHoraAte.TabIndex = 18;
			lblHoraAte.Text = "Hora do atendimento";
			// 
			// lblProf
			// 
			lblProf.AutoSize = true;
			lblProf.Location = new Point(246, 133);
			lblProf.Name = "lblProf";
			lblProf.Size = new Size(136, 15);
			lblProf.TabIndex = 19;
			lblProf.Text = "Profissional Responsável";
			// 
			// lblServ
			// 
			lblServ.AutoSize = true;
			lblServ.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblServ.Location = new Point(271, 223);
			lblServ.Name = "lblServ";
			lblServ.Size = new Size(149, 25);
			lblServ.TabIndex = 20;
			lblServ.Text = "Serviço Realizado";
			// 
			// txtBServDesc
			// 
			txtBServDesc.Location = new Point(246, 270);
			txtBServDesc.Multiline = true;
			txtBServDesc.Name = "txtBServDesc";
			txtBServDesc.Size = new Size(213, 58);
			txtBServDesc.TabIndex = 21;
			// 
			// DgvPetShop
			// 
			DgvPetShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgvPetShop.Location = new Point(12, 343);
			DgvPetShop.Name = "DgvPetShop";
			DgvPetShop.RowTemplate.Height = 25;
			DgvPetShop.Size = new Size(672, 143);
			DgvPetShop.TabIndex = 22;
			// 
			// lblIdadeAn
			// 
			lblIdadeAn.AutoSize = true;
			lblIdadeAn.Location = new Point(1, 296);
			lblIdadeAn.Name = "lblIdadeAn";
			lblIdadeAn.Size = new Size(36, 15);
			lblIdadeAn.TabIndex = 24;
			lblIdadeAn.Text = "Idade";
			// 
			// txtBIdadeAnimal
			// 
			txtBIdadeAnimal.Location = new Point(1, 314);
			txtBIdadeAnimal.Name = "txtBIdadeAnimal";
			txtBIdadeAnimal.Size = new Size(213, 23);
			txtBIdadeAnimal.TabIndex = 23;
			// 
			// lblIdProp
			// 
			lblIdProp.AutoSize = true;
			lblIdProp.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdProp.Location = new Point(203, 9);
			lblIdProp.Name = "lblIdProp";
			lblIdProp.Size = new Size(11, 10);
			lblIdProp.TabIndex = 25;
			lblIdProp.Text = "id";
			// 
			// lblIdAte
			// 
			lblIdAte.AutoSize = true;
			lblIdAte.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdAte.Location = new Point(409, 9);
			lblIdAte.Name = "lblIdAte";
			lblIdAte.Size = new Size(11, 10);
			lblIdAte.TabIndex = 26;
			lblIdAte.Text = "id";
			// 
			// lblIdServico
			// 
			lblIdServico.AutoSize = true;
			lblIdServico.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdServico.Location = new Point(409, 223);
			lblIdServico.Name = "lblIdServico";
			lblIdServico.Size = new Size(11, 10);
			lblIdServico.TabIndex = 27;
			lblIdServico.Text = "id";
			// 
			// lblIdAnimal
			// 
			lblIdAnimal.AutoSize = true;
			lblIdAnimal.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdAnimal.Location = new Point(142, 153);
			lblIdAnimal.Name = "lblIdAnimal";
			lblIdAnimal.Size = new Size(11, 10);
			lblIdAnimal.TabIndex = 28;
			lblIdAnimal.Text = "id";
			// 
			// btnSalvar
			// 
			btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnSalvar.Location = new Point(552, 30);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(111, 41);
			btnSalvar.TabIndex = 29;
			btnSalvar.Text = "Salvar";
			btnSalvar.UseVisualStyleBackColor = true;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// btnEditar
			// 
			btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnEditar.Location = new Point(552, 82);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(111, 42);
			btnEditar.TabIndex = 30;
			btnEditar.Text = "Editar";
			btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			btnExcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnExcluir.Location = new Point(552, 141);
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Size = new Size(111, 41);
			btnExcluir.TabIndex = 31;
			btnExcluir.Text = "Excluir";
			btnExcluir.UseVisualStyleBackColor = true;
			// 
			// txtBBaia
			// 
			txtBBaia.Location = new Point(246, 200);
			txtBBaia.Name = "txtBBaia";
			txtBBaia.Size = new Size(213, 23);
			txtBBaia.TabIndex = 32;
			// 
			// lblBaia
			// 
			lblBaia.AutoSize = true;
			lblBaia.Location = new Point(246, 182);
			lblBaia.Name = "lblBaia";
			lblBaia.Size = new Size(75, 15);
			lblBaia.TabIndex = 33;
			lblBaia.Text = "Baia Alocada";
			// 
			// lblIdBaia
			// 
			lblIdBaia.AutoSize = true;
			lblIdBaia.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdBaia.Location = new Point(388, 179);
			lblIdBaia.Name = "lblIdBaia";
			lblIdBaia.Size = new Size(11, 10);
			lblIdBaia.TabIndex = 34;
			lblIdBaia.Text = "id";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(696, 488);
			Controls.Add(lblIdBaia);
			Controls.Add(lblBaia);
			Controls.Add(txtBBaia);
			Controls.Add(btnExcluir);
			Controls.Add(btnEditar);
			Controls.Add(btnSalvar);
			Controls.Add(lblIdAnimal);
			Controls.Add(lblIdServico);
			Controls.Add(lblIdAte);
			Controls.Add(lblIdProp);
			Controls.Add(lblIdadeAn);
			Controls.Add(txtBIdadeAnimal);
			Controls.Add(DgvPetShop);
			Controls.Add(txtBServDesc);
			Controls.Add(lblServ);
			Controls.Add(lblProf);
			Controls.Add(lblHoraAte);
			Controls.Add(lblDataAte);
			Controls.Add(txtBProf);
			Controls.Add(txtBHoraAte);
			Controls.Add(txtBDataAte);
			Controls.Add(lblAtendimento);
			Controls.Add(lblPorte);
			Controls.Add(lblRaca);
			Controls.Add(lblNomeAnimal);
			Controls.Add(txtBPorte);
			Controls.Add(txtBRaca);
			Controls.Add(txtbNomeAnimal);
			Controls.Add(lblAnimal);
			Controls.Add(lblTelDono);
			Controls.Add(lblEndDono);
			Controls.Add(lblDono);
			Controls.Add(txtBTelProp);
			Controls.Add(txtBEndDono);
			Controls.Add(txtBNomeProp);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)DgvPetShop).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtBNomeProp;
		private TextBox txtBEndDono;
		private TextBox txtBTelProp;
		private Label lblDono;
		private Label lblEndDono;
		private Label lblTelDono;
		private Label lblAnimal;
		private TextBox txtbNomeAnimal;
		private TextBox txtBRaca;
		private TextBox txtBPorte;
		private Label lblNomeAnimal;
		private Label lblRaca;
		private Label lblPorte;
		private Label lblAtendimento;
		private TextBox txtBProf;
		private TextBox txtBHoraAte;
		private TextBox txtBDataAte;
		private Label lblDataAte;
		private Label lblHoraAte;
		private Label lblProf;
		private Label lblServ;
		private TextBox txtBServDesc;
		private DataGridView DgvPetShop;
		private Label lblIdadeAn;
		private TextBox txtBIdadeAnimal;
		private Label lblIdProp;
		private Label lblIdAte;
		private Label lblIdServico;
		private Label lblIdAnimal;
		private Button btnSalvar;
		private Button btnEditar;
		private Button btnExcluir;
		private TextBox txtBBaia;
		private Label lblBaia;
		private Label lblIdBaia;
	}
}