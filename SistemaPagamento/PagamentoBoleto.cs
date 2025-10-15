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
        public string Beneficiario;
        public string Pagador;
        public double Desconto;


        public override void ProcessarPagamento()
        {
            Console.WriteLine("Boleto Bancário - À Vista");
            Console.WriteLine("Cedente / Beneficiário: " + this.Beneficiario);
            Console.WriteLine("Sacado / Pagador: " + Pagador);
            Console.WriteLine("Desconto: " + this.Desconto);
        }

    }
}
