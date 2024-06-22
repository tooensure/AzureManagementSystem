using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Models
{
    public class Resource
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)] // Example: Limit the resource name length
        public string Name { get; set; }

        public string? Description { get; set; }
        public int SubscriptionId { get; set; } // Foreign key to Subscription table
        public Subscription Subscription { get; set; } // Navigation property

        // Other properties specific to your resources:
        // ...

        // Example:  If you have a resource type
        public ResourceType Type { get; set; }

        // Example: Resource Location
        public string Location { get; set; }

        // Example:  Resource Status
        public ResourceStatus Status { get; set; }

        // ... add more properties as needed

        // Navigation properties (if applicable): 
        // Example:  Relationship with a User
        public User CreatedBy { get; set; }
        public int? CreatedById { get; set; } // Foreign key
    }

    // Example:  Resource Type Enum
    public enum ResourceType
    {
        VirtualMachine,
        Database,
        StorageAccount,
        // ... add other resource types
    }

    // Example: Resource Status Enum
    public enum ResourceStatus
    {
        Active,
        Inactive,
        Pending,
        // ... add other resource statuses
    }
}
