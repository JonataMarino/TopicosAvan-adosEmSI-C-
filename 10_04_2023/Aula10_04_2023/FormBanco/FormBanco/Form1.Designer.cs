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
			SuspendLayout();
			// 
			// lblNameCliente
			// 
			lblNameCliente.AutoSize = true;
			lblNameCliente.Location = new Point(32, 20);
			lblNameCliente.Name = "lblNameCliente";
			lblNameCliente.Size = new Size(97, 15);
			lblNameCliente.TabIndex = 0;
			lblNameCliente.Text = "Nome do Cliente";
			// 
			// txtbNameCliente
			// 
			txtbNameCliente.Location = new Point(32, 38);
			txtbNameCliente.Name = "txtbNameCliente";
			txtbNameCliente.Size = new Size(197, 23);
			txtbNameCliente.TabIndex = 1;
			// 
			// txtbTelefone
			// 
			txtbTelefone.Location = new Point(32, 98);
			txtbTelefone.Name = "txtbTelefone";
			txtbTelefone.Size = new Size(197, 23);
			txtbTelefone.TabIndex = 3;
			// 
			// lblTelefone
			// 
			lblTelefone.AutoSize = true;
			lblTelefone.Location = new Point(32, 80);
			lblTelefone.Name = "lblTelefone";
			lblTelefone.Size = new Size(51, 15);
			lblTelefone.TabIndex = 2;
			lblTelefone.Text = "Telefone";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtbTelefone);
			Controls.Add(lblTelefone);
			Controls.Add(txtbNameCliente);
			Controls.Add(lblNameCliente);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblNameCliente;
		private TextBox txtbNameCliente;
		private TextBox txtbTelefone;
		private Label lblTelefone;
	}
}