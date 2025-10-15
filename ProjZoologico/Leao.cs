using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjZoologico
{
    public class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Rugido");
        }
        public override void toString()
        {
            Console.WriteLine("Animal: Leão");
            base.toString();
        }
    }
}
