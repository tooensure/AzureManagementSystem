using AzureManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Interfaces.IRepositories
{
    public interface IResourcesRepository
    {
        Task<Resource> CreateAsync(Resource resource);
        Task<Resource?> GetAsync(int id);
        Task<bool> DeleteAsync(int id);
        // Add other methods as needed (e.g., UpdateAsync, GetAllAsync)
    }
}
