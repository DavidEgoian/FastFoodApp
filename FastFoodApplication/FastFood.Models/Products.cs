using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

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
        public override bool Equals(object obj)
        {
            return new ProductEqualityComparer().Equals(this, obj as Product);
        }
        public override int GetHashCode()
        {
            return new ProductEqualityComparer().GetHashCode(this);
        }
    }
    public class ProductEqualityComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            return x.Title == y.Title;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            return obj.Id;
        }
    }
}
