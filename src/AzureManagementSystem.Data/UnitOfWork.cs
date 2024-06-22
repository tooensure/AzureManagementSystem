﻿using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Interfaces.IServices;
using AzureManagementSystem.Data.Services;
using AzureManagementSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork()
        {

            IResourcesRepository resources = new ResourcesRepository();
            IUsersRepository users = new UsersRepository();
            IRolesRepository roles = new RolesRepository();

            Resources = new ResourceService(resources);
            Roles = new RoleService(roles);
            Users = new UserService(users);

        }
        public IResourceService Resources { get; }
        public IRoleService Roles { get; }
        public IUserService Users { get; }

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