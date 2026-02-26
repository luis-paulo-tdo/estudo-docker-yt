namespace _01_ApiLivros.Models
{
    public class Livro
    {
        public Livro(Guid Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
