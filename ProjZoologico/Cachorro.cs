using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjZoologico
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
        public override void toString()
        {
            Console.WriteLine("Animal: Cachorro");
            base.toString();
        }
    }
}
