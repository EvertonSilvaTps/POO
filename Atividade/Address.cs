using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class Address
    {
        public string? Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; } = String.Empty;
        public string ZipCode { get; set; }
        public string? Complement { get; set; }  // ? pode ser null
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; } = string.Empty;

        public Address(string street, int number, string neighborhood, string zipCode, string? complement, string city, string state, string country) // Este é o método construtor, essa definição faz com que vai precisar informar essas propriedades
        {
            this.Street = street;  //Cidade
            this.Number = number;  //Número
            this.Neighborhood = neighborhood;  //Barrio                   // shift + alt  + seta pra baixo = replica em todos
            this.ZipCode = zipCode;  //CódigoPostal
            this.Complement = complement; //Complemento
            this.City = city;  //Cidade
            this.State = State;  //Estado
            this.Country = Country;  //País
        }

        public void mostrarInfo()
        {
            Console.WriteLine($"Endereço: {Street}, {Number}");
            Console.WriteLine($"Bairro: {Neighborhood}");
            Console.WriteLine($"CEP: {ZipCode}");
            if (Complement != null)
            {
                Console.WriteLine($"Complemento: {Complement}");
            }
            Console.WriteLine($"Cidade: {City}");
            Console.WriteLine($"Estado: {State}");
            Console.WriteLine($"Altura: {Country}");
        }

    }
}
