using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_App_BE.Data
{
    public interface IUser
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        string? Email { get; set; }
        string? Username { get; set; }
        string? Password { get; set; }
        string? Phone { get; set; }
    }
    
    [Table("Users.User")]
    public class User : Base, IUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
    }
}
