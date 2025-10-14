using ProjFuncionario;
using System.Runtime.CompilerServices;

Funcionario[] funcionarios;

Console.Write("Informe quantos funcionários quer cadastrar: ");
int qutFuncionarios = int.Parse(Console.ReadLine());

funcionarios = new Funcionario[qutFuncionarios];

int Escolha;


for (int i = 0; i < funcionarios.Length; i++)
{
    Console.Write("Digite [1] cadastrar CLT ou [2] cadastrar PJ: ");
    Escolha = int.Parse(Console.ReadLine());

    while (true)
    {
        if (Escolha == 1)
        {
            funcionarios[i] = new FuncionarioCLT();    

            Console.Write("Nome: ");
            funcionarios[i].SetNome(Console.ReadLine());
            Console.Write("Salario Base: ");
            funcionarios[i].SetSalarioBase(double.Parse(Console.ReadLine()));
            Console.Write("Bonus: ");
            ((FuncionarioCLT)funcionarios[i]).SetBonus(double.Parse(Console.ReadLine()));
            break;
        }
        else if (Escolha == 2)
        {
            funcionarios[i] = new FuncionarioPJ();
            
            Console.Write("Nome: ");
            funcionarios[i].SetNome(Console.ReadLine());
            Console.Write("Salario Base: ");
            funcionarios[i].SetSalarioBase(double.Parse(Console.ReadLine()));
            Console.Write("Horas trabalhadas: ");
            ((FuncionarioPJ)funcionarios[i]).setHorasTrabalhadas(int.Parse(Console.ReadLine()));
            Console.Write("Valor Hora: ");
            ((FuncionarioPJ)funcionarios[i]).setValorHora(double.Parse(Console.ReadLine()));
            break;
        }
        else
        {
            Console.Write("Informe um número válido (1 ou 2): ");
            Escolha = int.Parse(Console.ReadLine());
        }
    }
}
Console.WriteLine();

for  (int i = 0; i < funcionarios.Length; i++)
{
    Console.WriteLine();
    funcionarios[i].ExibirInfo();
}

Console.ReadKey();