namespace Ecommerce_App_BE.Data
{
    public interface IBase
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        int ID { get; set; }

        /// <summary>Gets or sets the custom key.</summary>
        /// <value>The custom key.</value>
        string? CustomKey { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets a value indicating whether the active.</summary>
        /// <value>True if active, false if not.</value>
        bool Active { get; set; }

    }

    public abstract class Base : IBase
    {
        public int ID { get; set; }
        public string? CustomKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Active { get; set; }
    }
}
