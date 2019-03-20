using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
	public partial class frmFuncionarios : Form
	{
		public frmFuncionarios()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			string nome, estadoCivil;
			nome = txtnome.Text;
			if (rdbCasado.Checked == true)
			{
				estadoCivil = "Casado(a)";
			}else if(rdbSolteiro.Checked == true)
			{
				estadoCivil = "Solteiro(a)";
			}
			else
			{
				MessageBox.Show("Escolha um estado civil");
				return;
			}
			SalvarFuncionario(nome, estadoCivil);
			LimparFuncionario();
			}

		

		private void SalvarFuncionario(string nome, string estadoCivil)
		{
			StreamWriter arquivo;
			string caminho = "C:\\sistema1\\clientes.txt";
			arquivo = File.AppendText(caminho);
			arquivo.WriteLine();
			arquivo.WriteLine("Cadastro de Funcionario");
			arquivo.WriteLine("Nome: " + nome);
			arquivo.WriteLine("Estado Civil: " + estadoCivil);
			arquivo.WriteLine("_____________________");
			arquivo.WriteLine();
			arquivo.Close();
			MessageBox.Show("Funcionario salvo com sucesso!!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
		private void LimparFuncionario()
		{
			txtnome.Clear();
			rdbCasado.Checked = false;
			rdbSolteiro.Checked = false;

		}




	}
}
