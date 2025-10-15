using ProjZoologico;

void CadastroAnimal()
{   
    Console.WriteLine("   Cadastro do Animal    \n\n");

    Console.Write("Quantos animais gostaria de cadastrar: ");
    int QtddAnimal = int.Parse(Console.ReadLine());

    Animal[] animais = new Animal[QtddAnimal];

    for (int i = 0; i < animais.Length; i++)
    {
        Console.Write("\n1-Cachorro\n2-Gato\n3-Leão");
        Console.Write("\nQual o tipo de animal: ");
        int TipoAnimal = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (true)
        {
            if (TipoAnimal == 1)
            {
                animais[i] = new Cachorro();

                Console.WriteLine("Animal: Cachorro ");
                animais[i].EmitirSom();
                Console.Write("Informe o nome do cachorro: ");
                animais[i].setNome(Console.ReadLine());
                Console.Write("Informa a idade: ");
                animais[i].setIdade(int.Parse(Console.ReadLine()));
                Console.Clear();
                break;
            }
            else if (TipoAnimal == 2)
            {
                animais[i] = new Gato();

                Console.WriteLine("Animal: Gato ");
                animais[i].EmitirSom();
                Console.Write("Informe o nome do gato: ");
                animais[i].setNome(Console.ReadLine());
                Console.Write("Informa a idade: ");
                animais[i].setIdade(int.Parse(Console.ReadLine()));
                Console.Clear();
                break;
            }
            else if (TipoAnimal == 3)
            {
                animais[i] = new Leao();

                animais[i].EmitirSom();
                Console.Write("Informe o nome do leão: ");
                animais[i].setNome(Console.ReadLine());
                Console.Write("Informa a idade: ");
                animais[i].setIdade(int.Parse(Console.ReadLine()));
                Console.Clear();
                break;
            }
            else
            {
                Console.Write("Informe um número válido (1, 2 ou 3): ");
                TipoAnimal = int.Parse(Console.ReadLine());
            }
        }
    }
    Console.WriteLine();
    
    for (int i = 0; i < animais.Length; i++)
    {
        Console.WriteLine();
        animais[i].toString();
    }
}


CadastroAnimal();

Console.ReadKey();