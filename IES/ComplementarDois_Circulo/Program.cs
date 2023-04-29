using ComplementarDois_Circulo;

Circulo circulo = new Circulo();

Console.WriteLine("Informe o RAIO de um círculo: ");

circulo.Raio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("=======================================");

Console.WriteLine("Área: " + circulo.Area());
Console.WriteLine("Comprimento: " + circulo.Comprimento());

Console.WriteLine("Pressione qualquer tecla para finalizar.");
Console.ReadKey();