namespace SegundoProjeto
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        private Departamento[] Departamentos { get; } = new Departamento[10];

        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
        {
            if (quantidadeDepartamentos < 10)
            {
                Departamentos[quantidadeDepartamentos++] = d;
            }
        }

        public int ObterQuantidadeDepartamentos()
        {
            return quantidadeDepartamentos;
        }

        public Departamento DepartamentoPorIndice(int indice)
        {
            return Departamentos[indice];
        }
    }
}
