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
        public string NumeroCartao { get; set; }
        public int DataValidade { get; set; }
        public int CVV {  get; set; }
        public string NomeTitular { get; set; }
        public string Bandeira { get; set; }
        public double Juros;

        public override void ProcessarPagamento()
        {
            Console.WriteLine("Dados do Cartão de Crédito\n");
            Console.WriteLine("Nome do Titular: " + this.NomeTitular);
            Console.WriteLine("Bandeira" + this.Bandeira);
            Console.Write("Número do Cartão: " + this.NumeroCartao);
            Console.WriteLine("Data de Validade: " + this.DataValidade);
            Console.WriteLine("Código de Segurança: " + this.CVV);
        }

    }
}
