using Atividade;
using System.Numerics;

#region
Pessoa[] pessoa = new Pessoa[3];

for (int i = 0; i < pessoa.Length; i++)
{
    pessoa[i] = new Pessoa();
        
    Console.Write("Digite o nome da pessoa: ");
    pessoa[i].setNome(Console.ReadLine());
    Console.Write("Digite o sobrenome da pessoa: ");
    pessoa[i].setSobrenome(Console.ReadLine());
    Console.Write("Digite a idade da pessoa: ");
    pessoa[i].setIdade(int.Parse((Console.ReadLine())));
    Console.Write("Digite o sexo da pessoa [M/F]: ");
    pessoa[i].setSexo(char.Parse(Console.ReadLine()));
    Console.Write("Digite a altura da pessoa: ");
    pessoa[i].setAltura((double.Parse(Console.ReadLine())));
}

for (int i = 0; i < pessoa.Length; i++)
{
    pessoa[i].mostrarInfo();
}
#endregion

Pessoa person = new Pessoa();

person.setNome("João");
person.setSobrenome("Silva");
person.setIdade(30);
person.setSexo('M');
person.setAltura(1.75);
person.Address = new Address("Rua A", 123, "Bairro B", "12345-678", null, "Cidade C", "Estado D", "País E");

person.mostrarInfo();