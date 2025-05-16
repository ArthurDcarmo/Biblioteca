namespace Biblioteca
{
    public class Livro : ItemBiblioteca, Emprestavel
    {
        public Livro(string titulo, int anopublicacao) : base(titulo, anopublicacao)
        {
        }

        public bool PodeSerEmprestado()
        {
            throw new NotImplementedException();
        }
    }
}