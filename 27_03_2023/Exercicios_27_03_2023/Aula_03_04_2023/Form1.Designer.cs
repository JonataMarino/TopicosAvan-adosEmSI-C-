namespace Aula_03_04_2023
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.ValorA = new System.Windows.Forms.Label();
			this.boxValorA = new System.Windows.Forms.TextBox();
			this.boxValorB = new System.Windows.Forms.TextBox();
			this.ValorB = new System.Windows.Forms.Label();
			this.boxValorC = new System.Windows.Forms.TextBox();
			this.ValorC = new System.Windows.Forms.Label();
			this.Calcular = new System.Windows.Forms.Button();
			this.cabecalho1 = new System.Windows.Forms.Label();
			this.cabecalho2 = new System.Windows.Forms.Label();
			this.boxPeso = new System.Windows.Forms.TextBox();
			this.boxAltura = new System.Windows.Forms.TextBox();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblAltura = new System.Windows.Forms.Label();
			this.btnIMC = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ValorA
			// 
			this.ValorA.AutoSize = true;
			this.ValorA.Location = new System.Drawing.Point(31, 24);
			this.ValorA.Name = "ValorA";
			this.ValorA.Size = new System.Drawing.Size(14, 13);
			this.ValorA.TabIndex = 0;
			this.ValorA.Text = "A";
			// 
			// boxValorA
			// 
			this.boxValorA.Location = new System.Drawing.Point(14, 40);
			this.boxValorA.Name = "boxValorA";
			this.boxValorA.Size = new System.Drawing.Size(53, 20);
			this.boxValorA.TabIndex = 1;
			// 
			// boxValorB
			// 
			this.boxValorB.Location = new System.Drawing.Point(113, 40);
			this.boxValorB.Name = "boxValorB";
			this.boxValorB.Size = new System.Drawing.Size(53, 20);
			this.boxValorB.TabIndex = 3;
			// 
			// ValorB
			// 
			this.ValorB.AutoSize = true;
			this.ValorB.Location = new System.Drawing.Point(133, 24);
			this.ValorB.Name = "ValorB";
			this.ValorB.Size = new System.Drawing.Size(14, 13);
			this.ValorB.TabIndex = 2;
			this.ValorB.Text = "B";
			// 
			// boxValorC
			// 
			this.boxValorC.Location = new System.Drawing.Point(216, 40);
			this.boxValorC.Name = "boxValorC";
			this.boxValorC.Size = new System.Drawing.Size(53, 20);
			this.boxValorC.TabIndex = 5;
			// 
			// ValorC
			// 
			this.ValorC.AutoSize = true;
			this.ValorC.Location = new System.Drawing.Point(237, 24);
			this.ValorC.Name = "ValorC";
			this.ValorC.Size = new System.Drawing.Size(14, 13);
			this.ValorC.TabIndex = 4;
			this.ValorC.Text = "C";
			// 
			// Calcular
			// 
			this.Calcular.Location = new System.Drawing.Point(100, 101);
			this.Calcular.Name = "Calcular";
			this.Calcular.Size = new System.Drawing.Size(75, 23);
			this.Calcular.TabIndex = 6;
			this.Calcular.Text = "Calcular";
			this.Calcular.UseVisualStyleBackColor = true;
			this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
			// 
			// cabecalho1
			// 
			this.cabecalho1.AutoSize = true;
			this.cabecalho1.Location = new System.Drawing.Point(12, 9);
			this.cabecalho1.Name = "cabecalho1";
			this.cabecalho1.Size = new System.Drawing.Size(104, 13);
			this.cabecalho1.TabIndex = 7;
			this.cabecalho1.Text = "Equação de 2º Grau";
			// 
			// cabecalho2
			// 
			this.cabecalho2.AutoSize = true;
			this.cabecalho2.Location = new System.Drawing.Point(12, 152);
			this.cabecalho2.Name = "cabecalho2";
			this.cabecalho2.Size = new System.Drawing.Size(67, 13);
			this.cabecalho2.TabIndex = 8;
			this.cabecalho2.Text = "Calcular IMC";
			// 
			// boxPeso
			// 
			this.boxPeso.Location = new System.Drawing.Point(12, 195);
			this.boxPeso.Name = "boxPeso";
			this.boxPeso.Size = new System.Drawing.Size(55, 20);
			this.boxPeso.TabIndex = 9;
			// 
			// boxAltura
			// 
			this.boxAltura.Location = new System.Drawing.Point(90, 195);
			this.boxAltura.Name = "boxAltura";
			this.boxAltura.Size = new System.Drawing.Size(57, 20);
			this.boxAltura.TabIndex = 10;
			// 
			// lblPeso
			// 
			this.lblPeso.AutoSize = true;
			this.lblPeso.Location = new System.Drawing.Point(14, 179);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(31, 13);
			this.lblPeso.TabIndex = 11;
			this.lblPeso.Text = "Peso";
			// 
			// lblAltura
			// 
			this.lblAltura.AutoSize = true;
			this.lblAltura.Location = new System.Drawing.Point(87, 179);
			this.lblAltura.Name = "lblAltura";
			this.lblAltura.Size = new System.Drawing.Size(34, 13);
			this.lblAltura.TabIndex = 12;
			this.lblAltura.Text = "Altura";
			// 
			// btnIMC
			// 
			this.btnIMC.Location = new System.Drawing.Point(176, 193);
			this.btnIMC.Name = "btnIMC";
			this.btnIMC.Size = new System.Drawing.Size(75, 23);
			this.btnIMC.TabIndex = 13;
			this.btnIMC.Text = "Calcular";
			this.btnIMC.UseVisualStyleBackColor = true;
			this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 246);
			this.Controls.Add(this.btnIMC);
			this.Controls.Add(this.lblAltura);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.boxAltura);
			this.Controls.Add(this.boxPeso);
			this.Controls.Add(this.cabecalho2);
			this.Controls.Add(this.cabecalho1);
			this.Controls.Add(this.Calcular);
			this.Controls.Add(this.boxValorC);
			this.Controls.Add(this.ValorC);
			this.Controls.Add(this.boxValorB);
			this.Controls.Add(this.ValorB);
			this.Controls.Add(this.boxValorA);
			this.Controls.Add(this.ValorA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ValorA;
		private System.Windows.Forms.TextBox boxValorA;
		private System.Windows.Forms.TextBox boxValorB;
		private System.Windows.Forms.Label ValorB;
		private System.Windows.Forms.TextBox boxValorC;
		private System.Windows.Forms.Label ValorC;
		private System.Windows.Forms.Button Calcular;
		private System.Windows.Forms.Label cabecalho1;
		private System.Windows.Forms.Label cabecalho2;
		private System.Windows.Forms.TextBox boxPeso;
		private System.Windows.Forms.TextBox boxAltura;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblAltura;
		private System.Windows.Forms.Button btnIMC;
	}
}

