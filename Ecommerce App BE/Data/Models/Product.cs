using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_App_BE.Data.Models
{
    public interface IProduct : IItemBase
    {
        string? Name { get; set; }
        string? Description { get; set; }
        string? ImageUrl { get; set; }
        string? KeyWords { get; set; }

    }
    
    [Table("Products.Product")]
    public class Product : ItemBase
    {

    }
}