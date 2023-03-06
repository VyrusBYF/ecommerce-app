using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_App_BE.Data.Models
{
    public interface ICart : IBase
    {
        #region Base Properties
        int UserID { get; set; }
        int SessionID { get; set; }
        int TotalItems { get; set; }
        decimal? TotalPrice { get; set; }
        #endregion

        #region Associated Objects
        ICollection<Product>? Products { get; set; }
        #endregion
    }

    public class Cart : ICart
    {
        #region Base Properties
        public int UserID { get; set; }
        public int SessionID { get; set; }
        public int TotalItems { get; set; }
        public decimal? TotalPrice { get; set; }
        public int ID { get; set; }
        public string? CustomKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Active { get; set; }
        #endregion

        #region Associated Objects
        public ICollection<Product>? Products { get; set; }
        #endregion
    }
}