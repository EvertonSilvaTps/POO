using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace Atividade
{
    public class Pessoa   //   Classe
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }                // Propriedades
        public char Sexo { get; set; }
        public double Altura { get; set; }
        public Address Address;



        public Pessoa()     // ctor (preenche automático o método construtor)
        {

        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.Sobrenome;
        }

        public void setIdade(int idade)
        {
            this.Idade = idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        public void setSexo(char sexo)
        {
            this.Sexo = sexo;
        }

        public char getSexo()
        {
            return this.Sexo;
        }

        public void setAltura(double altura)
        {
            this.Altura = altura;
        }

        public double getAltura()
        {
            return this.Altura;
        }

        public void mostrarInfo()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Sobrenome: " + this.Sobrenome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("Sexo: " + this.Sexo);
            Console.WriteLine("Altura: " + this.Altura);
            this.Address.mostrarInfo();
        }

    }
}