using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Interfaces.IServices;
using AzureManagementSystem.Data.Services;
using AzureManagementSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription.Api
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork()
        {
            ISubscriptionRepository subscriptions = new SubscriptionsRepository();
            IResourcesRepository resources = new ResourcesRepository();
            IUsersRepository users = new UsersRepository();
            IRolesRepository roles = new RolesRepository();
        }
        public ISubscriptionRepository Subscriptions { get; }
        public IResourcesRepository Resources { get; }
        public IRolesRepository Roles { get; }
        public IUsersRepository Users { get; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
