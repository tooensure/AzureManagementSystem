using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string SubscriptionId { get; set; } // Your Azure Subscription ID

        [Required]
        [MaxLength(255)]
        public string DisplayName { get; set; }  // Friendly name for the subscription

        // Optional properties
        public string? TenantId { get; set; } // Azure AD tenant ID
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public User CreatedBy { get; set; }
        public int? CreatedById { get; set; } // Foreign key to the User table

        // Navigation properties (if applicable)
        // ...
    }
}
