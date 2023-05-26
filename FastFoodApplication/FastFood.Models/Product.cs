using System.ComponentModel.DataAnnotations;

namespace FastFood.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "ველის შევსება სავალდებულოა")]
        public string Title { get; set; }
        [Required(ErrorMessage = "ველის შევსება სავალდებულოა")]
        public double Price { get; set; }
        [Required(ErrorMessage = "ველის შევსება სავალდებულოა")]
        public int Quantity { get; set; }
    }
}
