namespace Biblioteca
{
    public abstract class ItemBiblioteca
    {


        private int AnoPublicacao;


        private string Titulo;

        public ItemBiblioteca(string titulo, int anopublicacao)
        {


            Titulo = titulo;
            AnoPublicacao = anopublicacao;
        }

        public string titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int anopublicacao
        {
            get { return anopublicacao; }
            set
            {
                if (anopublicacao <= 0)
                {
                    throw new ArgumentException("Não é possivel encontrar um livro com o ano 0");
                }
                else
                {
                    anopublicacao = value;
                }

            }
        }
        public virtual string ExibirDetalhes()
        {
            return $"Titulo : {Titulo},Ano :{AnoPublicacao}";
        }
    }
}