using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjZoologico
{
    public abstract class Animal
    {
        private string nome;
        private int idade;


        public abstract void EmitirSom();

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public string getNome()
        {
            return nome;
        }
        
        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getIdade()
        {
            return idade;
        }


        public virtual void toString()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
        }
    }
}
