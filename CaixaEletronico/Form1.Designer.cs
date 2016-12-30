namespace CaixaEletronico
{
    partial class Form1
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
            this.btnDeposito = new System.Windows.Forms.Button();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.cbxTipoConta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculaTributos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(231, 195);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(145, 23);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(60, 22);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(113, 20);
            this.txtTitular.TabIndex = 1;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(128, 149);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(128, 112);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(15, 29);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 4;
            this.lblTitular.Text = "Titular:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 119);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Conta Corrente:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 156);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(72, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo da C.C:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(18, 214);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(167, 20);
            this.txtValor.TabIndex = 7;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(18, 195);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(155, 13);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor à sacar/depositar na C.C:";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(231, 225);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(145, 23);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(193, 29);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(64, 13);
            this.lblSaldoTotal.TabIndex = 14;
            this.lblSaldoTotal.Text = "Saldo Total:";
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Location = new System.Drawing.Point(263, 22);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.Size = new System.Drawing.Size(113, 20);
            this.txtSaldoTotal.TabIndex = 1;
            // 
            // cbxTipoConta
            // 
            this.cbxTipoConta.DisplayMember = "0";
            this.cbxTipoConta.FormattingEnabled = true;
            this.cbxTipoConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança"});
            this.cbxTipoConta.Location = new System.Drawing.Point(101, 63);
            this.cbxTipoConta.Name = "cbxTipoConta";
            this.cbxTipoConta.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoConta.TabIndex = 15;
            this.cbxTipoConta.SelectedIndexChanged += new System.EventHandler(this.cbxTipoConta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de Conta:";
            // 
            // btnCalculaTributos
            // 
            this.btnCalculaTributos.Location = new System.Drawing.Point(263, 110);
            this.btnCalculaTributos.Name = "btnCalculaTributos";
            this.btnCalculaTributos.Size = new System.Drawing.Size(113, 23);
            this.btnCalculaTributos.TabIndex = 17;
            this.btnCalculaTributos.Text = "Calcula Tributos";
            this.btnCalculaTributos.UseVisualStyleBackColor = true;
            this.btnCalculaTributos.Click += new System.EventHandler(this.btnCalculaTributos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 286);
            this.Controls.Add(this.btnCalculaTributos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipoConta);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtSaldoTotal);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.btnDeposito);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoConta;
        private System.Windows.Forms.Button btnCalculaTributos;
    }
}

