using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public abstract class Pagamento
    {
        public double Valor;
        public int DataDePgto;

        public abstract void ProcessarPagamento();












    }
}
