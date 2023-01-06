using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models
{
    public class Users : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress]
        public string Mail { get; set; } = string.Empty;

        
        public string Password { get; set; } = string.Empty;
    }
}
