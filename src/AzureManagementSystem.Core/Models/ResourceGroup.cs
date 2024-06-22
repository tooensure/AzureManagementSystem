using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Models
{
    public class ResourceGroup
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ResourceGroupName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Location { get; set; }

        // Optional properties
        public string? SubscriptionId { get; set; } // Foreign key to the Subscription table
        public Subscription Subscription { get; set; } // Navigation property
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public User CreatedBy { get; set; }
        public int? CreatedById { get; set; } // Foreign key to the User table

        // Navigation properties (if applicable)
        // ...
    }
}
