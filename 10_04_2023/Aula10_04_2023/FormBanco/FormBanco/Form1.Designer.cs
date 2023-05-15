namespace FormBanco
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
			lblNameCliente = new Label();
			txtbNameCliente = new TextBox();
			txtbTelefone = new TextBox();
			lblTelefone = new Label();
			txtBEndereco = new TextBox();
			lblEndereco = new Label();
			txtBTipoConta = new TextBox();
			lblTipoconta = new Label();
			txtBClasseConta = new TextBox();
			lblClasseConta = new Label();
			txtBBeneficio = new TextBox();
			lblBeneficio = new Label();
			txtBLimite = new TextBox();
			lblLimite = new Label();
			btnSave = new Button();
			dgvNovaConta = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvNovaConta).BeginInit();
			SuspendLayout();
			// 
			// lblNameCliente
			// 
			lblNameCliente.AutoSize = true;
			lblNameCliente.Location = new Point(12, 21);
			lblNameCliente.Name = "lblNameCliente";
			lblNameCliente.Size = new Size(97, 15);
			lblNameCliente.TabIndex = 0;
			lblNameCliente.Text = "Nome do Cliente";
			// 
			// txtbNameCliente
			// 
			txtbNameCliente.Location = new Point(12, 39);
			txtbNameCliente.Name = "txtbNameCliente";
			txtbNameCliente.Size = new Size(197, 23);
			txtbNameCliente.TabIndex = 1;
			// 
			// txtbTelefone
			// 
			txtbTelefone.Location = new Point(12, 91);
			txtbTelefone.Name = "txtbTelefone";
			txtbTelefone.Size = new Size(197, 23);
			txtbTelefone.TabIndex = 3;
			// 
			// lblTelefone
			// 
			lblTelefone.AutoSize = true;
			lblTelefone.Location = new Point(12, 73);
			lblTelefone.Name = "lblTelefone";
			lblTelefone.Size = new Size(51, 15);
			lblTelefone.TabIndex = 2;
			lblTelefone.Text = "Telefone";
			// 
			// txtBEndereco
			// 
			txtBEndereco.Location = new Point(12, 151);
			txtBEndereco.Name = "txtBEndereco";
			txtBEndereco.Size = new Size(197, 23);
			txtBEndereco.TabIndex = 5;
			// 
			// lblEndereco
			// 
			lblEndereco.AutoSize = true;
			lblEndereco.Location = new Point(12, 133);
			lblEndereco.Name = "lblEndereco";
			lblEndereco.Size = new Size(56, 15);
			lblEndereco.TabIndex = 4;
			lblEndereco.Text = "Endereço";
			// 
			// txtBTipoConta
			// 
			txtBTipoConta.Location = new Point(231, 39);
			txtBTipoConta.Name = "txtBTipoConta";
			txtBTipoConta.Size = new Size(197, 23);
			txtBTipoConta.TabIndex = 7;
			// 
			// lblTipoconta
			// 
			lblTipoconta.AutoSize = true;
			lblTipoconta.Location = new Point(231, 21);
			lblTipoconta.Name = "lblTipoconta";
			lblTipoconta.Size = new Size(81, 15);
			lblTipoconta.TabIndex = 6;
			lblTipoconta.Text = "Tipo de Conta";
			// 
			// txtBClasseConta
			// 
			txtBClasseConta.Location = new Point(231, 104);
			txtBClasseConta.Name = "txtBClasseConta";
			txtBClasseConta.Size = new Size(197, 23);
			txtBClasseConta.TabIndex = 9;
			// 
			// lblClasseConta
			// 
			lblClasseConta.AutoSize = true;
			lblClasseConta.Location = new Point(231, 86);
			lblClasseConta.Name = "lblClasseConta";
			lblClasseConta.Size = new Size(91, 15);
			lblClasseConta.TabIndex = 8;
			lblClasseConta.Text = "Classe da Conta";
			// 
			// txtBBeneficio
			// 
			txtBBeneficio.Location = new Point(231, 164);
			txtBBeneficio.Name = "txtBBeneficio";
			txtBBeneficio.Size = new Size(197, 23);
			txtBBeneficio.TabIndex = 11;
			// 
			// lblBeneficio
			// 
			lblBeneficio.AutoSize = true;
			lblBeneficio.Location = new Point(231, 146);
			lblBeneficio.Name = "lblBeneficio";
			lblBeneficio.Size = new Size(107, 15);
			lblBeneficio.TabIndex = 10;
			lblBeneficio.Text = "Beneficio da Conta";
			// 
			// txtBLimite
			// 
			txtBLimite.Location = new Point(231, 215);
			txtBLimite.Name = "txtBLimite";
			txtBLimite.Size = new Size(197, 23);
			txtBLimite.TabIndex = 13;
			// 
			// lblLimite
			// 
			lblLimite.AutoSize = true;
			lblLimite.Location = new Point(231, 197);
			lblLimite.Name = "lblLimite";
			lblLimite.Size = new Size(97, 15);
			lblLimite.TabIndex = 12;
			lblLimite.Text = "Limite disponível";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(39, 295);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(118, 39);
			btnSave.TabIndex = 14;
			btnSave.Text = "SALVAR";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// dgvNovaConta
			// 
			dgvNovaConta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvNovaConta.Location = new Point(497, 39);
			dgvNovaConta.Name = "dgvNovaConta";
			dgvNovaConta.RowTemplate.Height = 25;
			dgvNovaConta.Size = new Size(240, 295);
			dgvNovaConta.TabIndex = 15;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 372);
			Controls.Add(dgvNovaConta);
			Controls.Add(btnSave);
			Controls.Add(txtBLimite);
			Controls.Add(lblLimite);
			Controls.Add(txtBBeneficio);
			Controls.Add(lblBeneficio);
			Controls.Add(txtBClasseConta);
			Controls.Add(lblClasseConta);
			Controls.Add(txtBTipoConta);
			Controls.Add(lblTipoconta);
			Controls.Add(txtBEndereco);
			Controls.Add(lblEndereco);
			Controls.Add(txtbTelefone);
			Controls.Add(lblTelefone);
			Controls.Add(txtbNameCliente);
			Controls.Add(lblNameCliente);
			Name = "Form1";
			Text = "x";
			((System.ComponentModel.ISupportInitialize)dgvNovaConta).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblNameCliente;
		private TextBox txtbNameCliente;
		private TextBox txtbTelefone;
		private Label lblTelefone;
		private TextBox txtBEndereco;
		private Label lblEndereco;
		private TextBox txtBTipoConta;
		private Label lblTipoconta;
		private TextBox txtBClasseConta;
		private Label lblClasseConta;
		private TextBox txtBBeneficio;
		private Label lblBeneficio;
		private TextBox txtBLimite;
		private Label lblLimite;
		private Button btnSave;
		private DataGridView dgvNovaConta;
	}
}