using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public interface IConta
    {
        void Depositar(decimal valor);
        void Sacar(decimal valor);
        decimal Saldo { get; }
    }
}
