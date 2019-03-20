namespace Cadastros
{
	partial class frmClientes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtnome = new System.Windows.Forms.TextBox();
			this.btnsalvar = new System.Windows.Forms.Button();
			this.lblnome = new System.Windows.Forms.Label();
			this.lbltelefone = new System.Windows.Forms.Label();
			this.lblcidade = new System.Windows.Forms.Label();
			this.masktelefone = new System.Windows.Forms.MaskedTextBox();
			this.cmbcidade = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(117, 53);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(150, 20);
			this.txtnome.TabIndex = 0;
			// 
			// btnsalvar
			// 
			this.btnsalvar.Location = new System.Drawing.Point(57, 175);
			this.btnsalvar.Name = "btnsalvar";
			this.btnsalvar.Size = new System.Drawing.Size(210, 49);
			this.btnsalvar.TabIndex = 1;
			this.btnsalvar.Text = "Salvar";
			this.btnsalvar.UseVisualStyleBackColor = true;
			this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
			// 
			// lblnome
			// 
			this.lblnome.AutoSize = true;
			this.lblnome.Location = new System.Drawing.Point(54, 56);
			this.lblnome.Name = "lblnome";
			this.lblnome.Size = new System.Drawing.Size(38, 13);
			this.lblnome.TabIndex = 4;
			this.lblnome.Text = "Nome:";
			// 
			// lbltelefone
			// 
			this.lbltelefone.AutoSize = true;
			this.lbltelefone.Location = new System.Drawing.Point(54, 93);
			this.lbltelefone.Name = "lbltelefone";
			this.lbltelefone.Size = new System.Drawing.Size(52, 13);
			this.lbltelefone.TabIndex = 5;
			this.lbltelefone.Text = "Telefone:";
			// 
			// lblcidade
			// 
			this.lblcidade.AutoSize = true;
			this.lblcidade.Location = new System.Drawing.Point(54, 128);
			this.lblcidade.Name = "lblcidade";
			this.lblcidade.Size = new System.Drawing.Size(43, 13);
			this.lblcidade.TabIndex = 6;
			this.lblcidade.Text = "Cidade:";
			// 
			// masktelefone
			// 
			this.masktelefone.Location = new System.Drawing.Point(117, 90);
			this.masktelefone.Mask = "(999) 000-0000";
			this.masktelefone.Name = "masktelefone";
			this.masktelefone.Size = new System.Drawing.Size(150, 20);
			this.masktelefone.TabIndex = 7;
			// 
			// cmbcidade
			// 
			this.cmbcidade.FormattingEnabled = true;
			this.cmbcidade.Items.AddRange(new object[] {
            "Americana",
            "Piracicaba",
            "Nova Odessa",
            "Sumaré",
            "Campinas"});
			this.cmbcidade.Location = new System.Drawing.Point(117, 128);
			this.cmbcidade.Name = "cmbcidade";
			this.cmbcidade.Size = new System.Drawing.Size(150, 21);
			this.cmbcidade.TabIndex = 8;
			// 
			// frmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 295);
			this.Controls.Add(this.cmbcidade);
			this.Controls.Add(this.masktelefone);
			this.Controls.Add(this.lblcidade);
			this.Controls.Add(this.lbltelefone);
			this.Controls.Add(this.lblnome);
			this.Controls.Add(this.btnsalvar);
			this.Controls.Add(this.txtnome);
			this.Name = "frmClientes";
			this.Text = "frmClientes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Button btnsalvar;
		private System.Windows.Forms.Label lblnome;
		private System.Windows.Forms.Label lbltelefone;
		private System.Windows.Forms.Label lblcidade;
		private System.Windows.Forms.MaskedTextBox masktelefone;
		private System.Windows.Forms.ComboBox cmbcidade;
	}
}