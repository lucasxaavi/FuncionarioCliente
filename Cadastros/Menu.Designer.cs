namespace Cadastros
{
	partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.btnfuncionarios = new System.Windows.Forms.Button();
			this.btnclientes = new System.Windows.Forms.Button();
			this.btnsair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnfuncionarios
			// 
			this.btnfuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnfuncionarios.Image")));
			this.btnfuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnfuncionarios.Location = new System.Drawing.Point(12, 12);
			this.btnfuncionarios.Name = "btnfuncionarios";
			this.btnfuncionarios.Size = new System.Drawing.Size(124, 61);
			this.btnfuncionarios.TabIndex = 0;
			this.btnfuncionarios.Text = "Funcionários";
			this.btnfuncionarios.UseVisualStyleBackColor = true;
			this.btnfuncionarios.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnclientes
			// 
			this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
			this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnclientes.Location = new System.Drawing.Point(171, 12);
			this.btnclientes.Name = "btnclientes";
			this.btnclientes.Size = new System.Drawing.Size(116, 61);
			this.btnclientes.TabIndex = 1;
			this.btnclientes.Text = "Clientes";
			this.btnclientes.UseVisualStyleBackColor = true;
			this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
			// 
			// btnsair
			// 
			this.btnsair.Image = ((System.Drawing.Image)(resources.GetObject("btnsair.Image")));
			this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsair.Location = new System.Drawing.Point(171, 111);
			this.btnsair.Name = "btnsair";
			this.btnsair.Size = new System.Drawing.Size(116, 59);
			this.btnsair.TabIndex = 2;
			this.btnsair.Text = "Sair";
			this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnsair.UseVisualStyleBackColor = true;
			this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 195);
			this.Controls.Add(this.btnsair);
			this.Controls.Add(this.btnclientes);
			this.Controls.Add(this.btnfuncionarios);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnfuncionarios;
		private System.Windows.Forms.Button btnclientes;
		private System.Windows.Forms.Button btnsair;
	}
}

