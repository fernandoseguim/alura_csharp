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
    public partial class Form1 : Form
    {

        Conta conta = new Conta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            conta.Titular = new Cliente("Fernando Seguim", 28);
            conta.Numero = 1;
            conta.Deposita(1000.00);
            MostraConta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conta.Deposita(Convert.ToDouble(txtValor.Text));
            MostraConta();
            
        }
               
        private void btnSacar_Click(object sender, EventArgs e)
        {
            
            bool sacou = conta.Saca(Convert.ToDouble(txtValor.Text));//testando idade
            if (sacou)
            {
                MessageBox.Show("Saldo da Conta do " + conta.Titular.Nome + " após saque: " + conta.Saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta do " + conta.Titular.Nome);
            }
            MostraConta();
        }

        private void MostraConta()
        {
            txtTitular.Text = conta.Titular.Nome;
            txtNumero.Text = conta.Numero.ToString();
            txtSaldo.Text = conta.Saldo.ToString();
            txtValor.Clear();
        }
    }
}