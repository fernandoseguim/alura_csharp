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

        ContaCorrente contaCorrente;
        ContaPoupanca contaPoupanca;
        TotalizadorDeContas saldoTotal;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            contaCorrente = new ContaCorrente();
            contaCorrente.Titular = new Cliente("Fernando Seguim", 28);
            contaCorrente.Numero = 1;
            contaCorrente.Deposita(1000.00);

            contaPoupanca = new ContaPoupanca();
            contaPoupanca.Titular = contaCorrente.Titular;
            contaPoupanca.Numero = contaCorrente.Numero;
            contaPoupanca.Deposita(3000.00);
            
            saldoTotal = new TotalizadorDeContas();
            saldoTotal.Adiciona(contaCorrente);
            saldoTotal.Adiciona(contaPoupanca);

            cbxTipoConta.SelectedIndex = 0;
            MostraConta(cbxTipoConta.SelectedIndex);
        }

        private void cbxTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostraConta(cbxTipoConta.SelectedIndex);
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {

            switch (cbxTipoConta.SelectedIndex)
            {
                case (int)Conta.tipo.Corrente:
                    contaCorrente.Deposita(Convert.ToDouble(txtValor.Text));
                    break;

                case (int)Conta.tipo.Poupanca:
                    contaPoupanca.Deposita(Convert.ToDouble(txtValor.Text));
                    break;
            }
            
            MostraConta(cbxTipoConta.SelectedIndex);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            switch (cbxTipoConta.SelectedIndex)
            {
                case (int)Conta.tipo.Corrente:
                    contaCorrente.Saca(Convert.ToDouble(txtValor.Text));
                    break;

                case (int)Conta.tipo.Poupanca:
                    contaPoupanca.Saca(Convert.ToDouble(txtValor.Text));
                    break;
            }
            
            MostraConta(cbxTipoConta.SelectedIndex);
        }

        private void btnCalculaTributos_Click(object sender, EventArgs e)
        {
            TotalizadorDeTributos totalizadorTributos =  new TotalizadorDeTributos();
            totalizadorTributos.Acumula(contaPoupanca);
            MessageBox.Show("Total de tributos: " + totalizadorTributos.Total.ToString());
        }

        private void MostraConta(int tipo)
        {
            switch (tipo)
            {
                case (int)Conta.tipo.Corrente:
                    btnCalculaTributos.Visible = false;
                    btnCalculaTributos.Enabled = false;
                    txtTitular.Text = contaCorrente.Titular.Nome;
                    txtNumero.Text = contaCorrente.Numero.ToString();
                    txtSaldo.Text = contaCorrente.Saldo.ToString();
                    break;

                case (int)Conta.tipo.Poupanca:
                    btnCalculaTributos.Visible = true;
                    btnCalculaTributos.Enabled = true;
                    txtTitular.Text = contaPoupanca.Titular.Nome;
                    txtNumero.Text = contaPoupanca.Numero.ToString();
                    txtSaldo.Text = contaPoupanca.Saldo.ToString();
                    break;
            }

            txtSaldoTotal.Text = saldoTotal.SaldoTotal.ToString();
            txtValor.Clear();   
        }
    }
}