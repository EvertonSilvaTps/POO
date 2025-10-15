using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public abstract class Pagamento
    {
        private decimal Valor {  get; set; }
        private DateTime DataPagamento { get; set; }

        public abstract void ProcessarPagamento(DateTime dt, decimal valor);

        public void setDataDePagamento(DateTime dt)
        {
            DataPagamento = dt;
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }
    }
}
