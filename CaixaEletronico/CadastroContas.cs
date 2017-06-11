using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroContas : Form
    {

        private Form1 appPrincipal;
        private int nextConta;
        public CadastroContas(Form1 appPrincipal)
        {
            this.appPrincipal = appPrincipal;
            this.NextConta = appPrincipal.QuatidadeContas + 1;
            InitializeComponent();

            txtNumeroConta.Text = Convert.ToString(this.NextConta);
        }

        public int NextConta { get => nextConta; set => nextConta = value; }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text;
            int idadeCliente = 0;
            try
            {
                idadeCliente = Convert.ToInt32(txtIdade.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato do número é invalido");
                
            }

            Cliente cliente = new Cliente(nomeCliente, idadeCliente);

            if (cliente.EhMaiorDeIdade())
            {
                Conta conta = new ContaCorrente(cliente, this.NextConta);
                this.appPrincipal.AddConta(conta);
            }
            else {
                MessageBox.Show("Idade inválida!");
            }

        }

    }
}
