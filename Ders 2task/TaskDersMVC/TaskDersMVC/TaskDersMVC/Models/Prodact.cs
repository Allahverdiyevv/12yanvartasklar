using System.ComponentModel.DataAnnotations.Schema;

namespace TaskDersMVC.Models
{
    public class Prodact
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        
        public string? Image { get; set; }
        public Categoria Categoria { get; set; }   

    }
}
