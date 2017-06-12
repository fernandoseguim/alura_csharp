namespace CaixaEletronico
{
    partial class CadastroContas
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
            this.lblTitularConta = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.btnCadastrarConta = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitularConta
            // 
            this.lblTitularConta.AutoSize = true;
            this.lblTitularConta.Location = new System.Drawing.Point(13, 13);
            this.lblTitularConta.Name = "lblTitularConta";
            this.lblTitularConta.Size = new System.Drawing.Size(36, 13);
            this.lblTitularConta.TabIndex = 0;
            this.lblTitularConta.Text = "Titular";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(16, 30);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(206, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Location = new System.Drawing.Point(16, 135);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroConta.TabIndex = 2;
            this.lblNumeroConta.Text = "Número da Conta";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(16, 151);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroConta.TabIndex = 3;
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.Location = new System.Drawing.Point(16, 187);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(124, 23);
            this.btnCadastrarConta.TabIndex = 4;
            this.btnCadastrarConta.Text = "Cadastrar Conta";
            this.btnCadastrarConta.UseVisualStyleBackColor = true;
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(236, 13);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(239, 30);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(55, 20);
            this.txtIdade.TabIndex = 6;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(13, 66);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 7;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(158, 66);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(16, 83);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(124, 20);
            this.txtRg.TabIndex = 9;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(161, 82);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(133, 20);
            this.txtCpf.TabIndex = 10;
            // 
            // CadastroContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 275);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnCadastrarConta);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.lblNumeroConta);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblTitularConta);
            this.Name = "CadastroContas";
            this.Text = "CadastroContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitularConta;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNumeroConta;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Button btnCadastrarConta;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
    }
}