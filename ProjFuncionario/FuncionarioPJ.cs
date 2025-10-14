using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFuncionario
{
    public class FuncionarioPJ : Funcionario
    {

        private int HorasTrabalhadas;
        private double ValorHora;

        public override double CalcularSalarioFinal()
        {
            return this.getSalarioBase() +  (this.HorasTrabalhadas * this.ValorHora);
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine("Horas Trabalhadas: " + this.HorasTrabalhadas);
            Console.WriteLine("Valor Hora: " + this.ValorHora);
            Console.WriteLine("Salario Total: " + this.CalcularSalarioFinal());
        }


        public void setHorasTrabalhadas(int HorasTrabalhadas)
        {
            this.HorasTrabalhadas = HorasTrabalhadas;
        }

        public int getHorasTrabalhadas()
        {
            return this.HorasTrabalhadas;
        }

        public void setValorHora(double ValorHora)
        {
            this.ValorHora = ValorHora;
        }

        public double getValorHora()
        {
            return this.ValorHora;
        }





    }
}
