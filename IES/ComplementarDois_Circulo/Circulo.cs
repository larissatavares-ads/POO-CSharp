namespace ComplementarDois_Circulo
{
    class Circulo
    {
        private readonly double PI = 3.14;
        //Igual a de com a porém com melhor performance
        private const double pi = 3.14;

        public double Raio { get; set; }

        public double Area()
        {
            return PI * Math.Pow(Raio, 2);
        }

        public double Comprimento()
        {
            return PI * Raio;
        }
    }
}
