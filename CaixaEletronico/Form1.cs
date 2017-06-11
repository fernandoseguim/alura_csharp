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
        private Conta[] contas;
        private int quatidadeContas;

        public int QuatidadeContas { get => quatidadeContas; private set => quatidadeContas = value; }

        public Form1()
        {
            contas = new Conta[100];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            contaCorrente = new ContaCorrente(new Cliente("Fernando Seguim", 28), 1);
            contaCorrente.Deposita(1000.00);
            quatidadeContas++;

            contaPoupanca = new ContaPoupanca(contaCorrente.Titular, 2);
            contaPoupanca.Deposita(3000.00);
            quatidadeContas++;

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
                    FazSaque(contaCorrente);
                    break;

                case (int)Conta.tipo.Poupanca:
                    FazSaque(contaPoupanca);
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
                    txtNumero.Text = contaCorrente.GetNumero().ToString();
                    txtSaldo.Text = contaCorrente.Saldo.ToString();
                    break;

                case (int)Conta.tipo.Poupanca:
                    btnCalculaTributos.Visible = true;
                    btnCalculaTributos.Enabled = true;
                    txtTitular.Text = contaPoupanca.Titular.Nome;
                    txtNumero.Text = contaPoupanca.GetNumero().ToString();
                    txtSaldo.Text = contaPoupanca.Saldo.ToString();
                    break;
            }

            txtSaldoTotal.Text = saldoTotal.SaldoTotal.ToString();
            txtValor.Clear();   
        }

        private void FazSaque(Conta conta)
        {
            try
            {
                conta.Saca(Convert.ToDouble(txtValor.Text));
            }
            catch (SaldoInsuficienteExecption ex)
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Valor inválido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao sacar valor!");
            }
        }
       
        public void AddConta(Conta conta)
        {
            contas[this.quatidadeContas] = conta;
            this.quatidadeContas++;
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            CadastroContas cadastroContas = new CadastroContas(this);
            cadastroContas.ShowDialog();
        }

        private void txtContas_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>
            {
                ContaComSaldo(2300),
                ContaComSaldo(1300),
                ContaComSaldo(2500)
            };
            var contasSaldo2000 = contas.Where(c => c.Saldo > 2000);

            double saldoTotal = contasSaldo2000.Sum(c => c.Saldo);

            foreach (Conta c in contasSaldo2000)
            {
                MessageBox.Show(string.Format("Conta numero {0} tem o saldo de: {1}", c.GetNumero(), c.Saldo));
            }

            MessageBox.Show(string.Format("Saldo Total é de: {0}", saldoTotal));
        }

        private Conta ContaComSaldo(double saldo)
        {
            Conta conta = new ContaCorrente(new Cliente("Fulano", 28), 1);
            conta.Deposita(saldo);
            return conta;
        }
    }
}