using SegundoProjeto;

var iesUFRA = new Instituicao()
{
    Nome = "UFRA",
    Endereco = new Endereco()
    {
        Rua = "Perimetral",
        Bairro = "Terra firme",
        Numero = "1000"
    }
};

var iesIFPA = new Instituicao() 
{
    Nome = "IFPA",
    Endereco = new Endereco()
    {
        Bairro = "Marco"
    }
};

var dptoEnsino = new Departamento("Computação");
var dptoAlimentos = new Departamento("Alimentos");
var dptoRevisao = new Departamento("Revisão");

iesUFRA.RegistrarDepartamento(dptoEnsino);
iesUFRA.RegistrarDepartamento(dptoAlimentos);
iesUFRA.RegistrarDepartamento(dptoRevisao);

iesIFPA.RegistrarDepartamento(dptoRevisao);

Console.WriteLine("UFRA");
for (int i = 0; i < iesUFRA.ObterQuantidadeDepartamentos(); i++)
{
    Console.WriteLine($"==> {iesUFRA.DepartamentoPorIndice(i).Nome}");
}

Console.WriteLine("IFPA");
for (int i = 0; i < iesIFPA.ObterQuantidadeDepartamentos(); i++)
{
    Console.WriteLine($"==> {iesIFPA.DepartamentoPorIndice(i).Nome}");
}

Console.WriteLine("Pressione qualquer tecla para continuar.");
Console.ReadKey();