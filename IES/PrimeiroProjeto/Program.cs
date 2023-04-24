using PrimeiroProjeto;

Instituicao instituicao = new Instituicao();

Console.WriteLine(instituicao.Tipo);

Console.WriteLine("Informe o nome da instituição: ");
instituicao.Nome = Console.ReadLine();

Console.WriteLine("Informe o endereço da instituição: ");
instituicao.Endereco = Console.ReadLine();

Console.WriteLine("===============================================================================");
Console.WriteLine($"Obrigada por informar os dados para a instituição {instituicao.Nome}");
Console.WriteLine($"Pressione qualquer tecla para encerrar...");
Console.ReadKey();


