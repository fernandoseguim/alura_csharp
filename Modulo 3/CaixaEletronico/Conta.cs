using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    
    public abstract class Conta
    {
               
        public enum tipo { Corrente = 0, Poupanca = 1 };

        
        private int numero;

        public int GetNumero()
        {
            return numero;
        }

        private void SetNumero(int numero)
        {
            this.numero = numero;
        }
        
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta(Cliente titular, int numero)
        {
            this.Titular = titular;
            SetNumero(numero);
        }

        public void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }

        public abstract void Saca(double valor);
        

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
            
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;
        }
    }
}
