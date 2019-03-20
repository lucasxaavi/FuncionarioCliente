namespace Cadastros
{
	partial class frmFuncionarios
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
			this.lblnome = new System.Windows.Forms.Label();
			this.gpbestadocivil = new System.Windows.Forms.GroupBox();
			this.rdbSolteiro = new System.Windows.Forms.RadioButton();
			this.rdbCasado = new System.Windows.Forms.RadioButton();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.gpbestadocivil.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(112, 61);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(131, 20);
			this.txtnome.TabIndex = 0;
			this.txtnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lblnome
			// 
			this.lblnome.AutoSize = true;
			this.lblnome.Location = new System.Drawing.Point(58, 61);
			this.lblnome.Name = "lblnome";
			this.lblnome.Size = new System.Drawing.Size(38, 13);
			this.lblnome.TabIndex = 1;
			this.lblnome.Text = "Nome:";
			// 
			// gpbestadocivil
			// 
			this.gpbestadocivil.Controls.Add(this.rdbSolteiro);
			this.gpbestadocivil.Controls.Add(this.rdbCasado);
			this.gpbestadocivil.Location = new System.Drawing.Point(61, 104);
			this.gpbestadocivil.Name = "gpbestadocivil";
			this.gpbestadocivil.Size = new System.Drawing.Size(182, 46);
			this.gpbestadocivil.TabIndex = 2;
			this.gpbestadocivil.TabStop = false;
			this.gpbestadocivil.Text = "Estado Civil:";
			this.gpbestadocivil.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// rdbSolteiro
			// 
			this.rdbSolteiro.AutoSize = true;
			this.rdbSolteiro.Location = new System.Drawing.Point(6, 19);
			this.rdbSolteiro.Name = "rdbSolteiro";
			this.rdbSolteiro.Size = new System.Drawing.Size(72, 17);
			this.rdbSolteiro.TabIndex = 3;
			this.rdbSolteiro.TabStop = true;
			this.rdbSolteiro.Text = "Solteiro(a)";
			this.rdbSolteiro.UseVisualStyleBackColor = true;
			// 
			// rdbCasado
			// 
			this.rdbCasado.AutoSize = true;
			this.rdbCasado.Location = new System.Drawing.Point(103, 19);
			this.rdbCasado.Name = "rdbCasado";
			this.rdbCasado.Size = new System.Drawing.Size(73, 17);
			this.rdbCasado.TabIndex = 4;
			this.rdbCasado.TabStop = true;
			this.rdbCasado.Text = "Casado(a)";
			this.rdbCasado.UseVisualStyleBackColor = true;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(61, 156);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(182, 50);
			this.btnSalvar.TabIndex = 3;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// frmFuncionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 284);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.gpbestadocivil);
			this.Controls.Add(this.lblnome);
			this.Controls.Add(this.txtnome);
			this.Name = "frmFuncionarios";
			this.Text = "frmFuncionarios";
			this.gpbestadocivil.ResumeLayout(false);
			this.gpbestadocivil.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Label lblnome;
		private System.Windows.Forms.GroupBox gpbestadocivil;
		private System.Windows.Forms.RadioButton rdbSolteiro;
		private System.Windows.Forms.RadioButton rdbCasado;
		private System.Windows.Forms.Button btnSalvar;
	}
}