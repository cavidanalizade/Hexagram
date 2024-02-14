using Hexagram.Core.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table { get; }
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task<T> Update(T entity);
        Task<bool> Create(T entity);
/*        bool Check(int id);
*/        Task<bool> DeleteAsync(int id);
        Task<bool> deleteAll();
        Task<int> Save();
    }
}
