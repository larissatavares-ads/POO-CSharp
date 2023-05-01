namespace ComplementarTres_Editora
{
    public class Editora
    {
        public string RazaoSocial { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }
        public Livro[] Livros { get; set; } = new Livro[10];
        private int quantidadeLivros = 0;

        public void RegistrarLivros(Livro livro)
        {
            if (this.quantidadeLivros < 10) {
                Livros[this.quantidadeLivros++] = livro;
            }
        }
    }
}
