namespace PruebaAzure.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public Nota(string content)
        {
            Content = content;
        }
    }
}
