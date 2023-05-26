using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public class Poupanca : IConta
    {
        private decimal saldo;

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }
    }
}
