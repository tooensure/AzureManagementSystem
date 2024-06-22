using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Data
{
    public interface IUnitOfWork: IDisposable
    {

        IResourceService Resources { get; }
        IRoleService Roles { get; }
        IUserService Users { get; }

        Task<int> SaveChangesAsync();
    }
}
