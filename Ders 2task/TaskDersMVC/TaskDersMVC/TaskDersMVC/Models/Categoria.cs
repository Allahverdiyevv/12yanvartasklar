namespace TaskDersMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Prodact> Prodacts { get; set; }

    }
}
