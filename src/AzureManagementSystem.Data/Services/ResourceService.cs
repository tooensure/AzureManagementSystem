using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Interfaces.IServices;
using AzureManagementSystem.Core.Models;
using AzureManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Data.Services
{
    public class ResourceService : GenericService<Resource>, IResourceService
    {
        public ResourceService(IRepository<Resource> repository) : base(repository)
        {
        }
    }
}
