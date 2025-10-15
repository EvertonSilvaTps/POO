using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaBancaria
    {
        private double Saldo;
        private string Titular;


        public double Depositar()
        {
            return 0;
        }

        public double Sacar()
        {
            return 0;
        }


        public void setSaldo(double saldo)
        {
            this.Saldo = saldo;
        }

        public double getSaldo()
        {
            return this.Saldo;
        }

        public void setTitular(string titular)
        {
            this.Titular = titular;
        }

        public string getTitular()
        {
            return this.Titular;
        }



    }
}   
