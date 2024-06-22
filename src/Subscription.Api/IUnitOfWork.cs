using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription.Api
{
    public interface IUnitOfWork : IDisposable
    {
        ISubscriptionRepository Subscriptions { get; }
        IResourcesRepository Resources { get; }
        IRolesRepository Roles { get; }
        IUsersRepository Users { get; }

        Task<int> SaveChangesAsync();
    }
}
