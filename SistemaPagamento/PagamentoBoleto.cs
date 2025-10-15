using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace SistemaPagamento
{
    public class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento(DateTime dt, decimal valor)
        {
            this.setValor(valor);
            this.setDataDePagamento(dt);
            Console.WriteLine("Pagamento efetuado com Boleto! R$ " + valor);
            Console.WriteLine(dt);
        }

    }
}
