using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Interfaces.IRepositories
{
    public interface IRepository<T>: IBaseEntityOperations<T> where T : class
    {
    }
}
