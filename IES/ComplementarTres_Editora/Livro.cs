namespace ComplementarTres_Editora
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }

        private Editora _editora;
        public Editora Editora
        {
            get { return this._editora; }
            set { this._editora = value; this._editora.RegistrarLivros(this) };
        }
        public Autor[] Autores { get; set; } = new Autor[5];
    }
}
