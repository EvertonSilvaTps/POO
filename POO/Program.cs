using POO;   //  Definir que a classe pessoa está dentro deste projeto

Pessoa pessoa = new Pessoa();    // Classe > Pessoa       // Objeto > pessoa            Pessoa() > Método construtor

pessoa.setNome("João");
pessoa.setIdade(25);
pessoa.setCpf("123.456;789-00");    //  Está populando as propriedades do objeto 'pessoa'
pessoa.setAltura(1.75);

Console.WriteLine(pessoa.getNome());
Console.WriteLine(pessoa.getIdade());    // Está usando métodos de operação pra buscar a propriedade (get), dentro do objeto 'pessoa'
Console.WriteLine(pessoa.getCpf());
Console.WriteLine(pessoa.getAltura());

Console.ReadKey();

Console.WriteLine(pessoa.Nome);     // Está acessando diretamente

