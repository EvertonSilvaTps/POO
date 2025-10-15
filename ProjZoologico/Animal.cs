using System;
using System.Collections.Generic;
using System.Linq;
using .Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjZoologico
{
    public abstract class Animal
    {
        private string nome;
        private int idade;

        //private int id;  // Atributo privado

        //public int Id  // A propriedade está publica, manipulável
        //{
        //    get { return idade; }
        //    set { idade = value; }
        //}


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
