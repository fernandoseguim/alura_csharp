using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {

        public override void Saca(double valor)
        {
            if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteExecption();
            }
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo -= valor;
            }
        }

    }
}
