using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Domain.Repositories
{
    public class ResourcesRepository : GenericRepository<Resource>, IResourcesRepository
    {
    }
}
