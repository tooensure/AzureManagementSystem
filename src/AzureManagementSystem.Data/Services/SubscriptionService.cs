using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Interfaces.IServices;
using AzureManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Data.Services
{
    public class SubscriptionService : GenericService<Subscription>, ISubscriptionService
    {
        public SubscriptionService(IRepository<Subscription> repository) : base(repository)
        {
        }
    }
}
