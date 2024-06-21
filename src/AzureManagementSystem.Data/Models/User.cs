using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        // Navigation properties (if applicable):
        // Example:  Many-to-many relationship with Role (through RoleUser)
        public ICollection<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();
    }
}
