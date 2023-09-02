string nome;
Console.Write("digite seu nome aqui...");

nome = Console.ReadLine()!;

string sobrenome;
Console.Write("digite seu sobrenome aqui...");

sobrenome = Console.ReadLine()!;


Console.WriteLine($"nome completo {nome} {sobrenome}");
Console.WriteLine($"nome catálogo {sobrenome.ToUpper()} {nome}");