using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public override void ProcessarPagamento(DateTime dt, decimal valor)
        {
            this.setValor(valor);
            this.setDataDePagamento(dt);
            
            Console.WriteLine("Pagamento efetuado com Cartão de Crédito! R$ " + valor);
            Console.WriteLine(dt);
        }

    }
}
