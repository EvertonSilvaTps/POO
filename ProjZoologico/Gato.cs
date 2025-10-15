using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjZoologico
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
        public override void toString()
        {
            Console.WriteLine("Animal: Gato");
            base.toString();
        }
    }
}
