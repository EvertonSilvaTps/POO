using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFuncionario
{
    internal class FuncionarioCLT : Funcionario       // Herança
    {
        private double Bonus;

        public override double CalcularSalarioFinal()             // Método obrigatório devido a classe primário estar com abstract
        {
            return this.getSalarioBase() + this.Bonus;
        }

        public void SetBonus(double Bonus)
        {
            this.Bonus = Bonus;
        }

        public double getBonus()
        {
            return this.Bonus;
        }


        public override void ExibirInfo()     // Sobreescrever
        {
            base.ExibirInfo();                              // 'base' > Ele chama o método da base que está herdando 
            Console.WriteLine("Bonus: " + this.Bonus);
            Console.WriteLine("Salario Total: " + this.CalcularSalarioFinal());
        }

    }
}
