using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param.Application.IRepositories
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }
       
        Task<int> CompleteAsync();
    }
}
