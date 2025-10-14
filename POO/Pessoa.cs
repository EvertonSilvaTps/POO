using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace POO  // Sempre o nome do projeto
{
    public class Pessoa  // Internal = usar só dentro do projeto  // utilizar em outros
    {
        public int Idade;  // proc + tab (monta a estrutura)
        public string Nome;
        public string Cpf;            //  São atributos
        public double Altura;

        public Pessoa()       // Método Construtor
        {

        }


        public void setIdade(int idade)    // Criação de método   =  Este é o set (definir)
        {
            this.Idade = idade;                    // Propriedade recebe a variável         // this (está é a instância
        }

        public int getIdade()                // Este é o get (retorno)            // Todo método precisa do get e set
        {
            return this.Idade;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setCpf(string cpf)
        {
            this.Cpf = cpf;
        }

        public string getCpf()
        {
            return this.Cpf;
        }

        public void setAltura(double altura)
        {
            this.Altura = altura;
        }

        public double getAltura()
        {
            return this.Altura;
        }

    }
}
