using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Interfaces.IServices
{
    public interface IService<T> : IBaseEntityOperations<T> where T : class
    {
    }
}
