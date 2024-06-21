using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string? Description { get; set; }

        // Navigation properties (if applicable):
        // Example:  Many-to-many relationship with User (through RoleUser)
        public ICollection<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();
    }
}
