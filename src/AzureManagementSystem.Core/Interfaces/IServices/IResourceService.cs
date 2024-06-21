using AzureManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Interfaces.IServices
{
    public interface IResourceService
    {
        Task<Resource> CreateResourceAsync(Resource resource);
        Task<Resource?> GetResourceAsync(int id);
        Task<bool> DeleteResourceAsync(int id);
        // ... (Other methods, like UpdateResourceAsync)
    }
}
