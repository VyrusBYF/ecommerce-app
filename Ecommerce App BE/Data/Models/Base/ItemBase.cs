namespace Ecommerce_App_BE.Data
{
    public interface IItemBase : IBase
    {
        decimal? UnitPrice { get; set; }
        int Quanitity { get; set; }
        int CurrentStock { get; set; }
        decimal? Discount { get; set; }
    }

    public abstract class ItemBase : IItemBase
    {
        public decimal? UnitPrice { get; set; }
        public int Quanitity { get; set; }
        public int CurrentStock { get; set; }
        public decimal? Discount { get; set; }
        public int ID { get; set; }
        public string? CustomKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Active { get; set; }
    }
}
