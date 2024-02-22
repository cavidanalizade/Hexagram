using Hexagram.Core.Entities.Common;
using Hexagram.DAL.DbContext;
using Hexagram.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.DAL.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();
      
        public async Task<bool> DeleteAsync(int id)
        {
            if (Table.Any(x => x.Id == id ))
            {
                var entity = Table.FirstOrDefault(x => x.Id == id);
                if (entity != null)
                 Table.Remove(entity);
                var AffectedRows = await Save();
                if (AffectedRows > 0) return true;

            }
            return false;
        }
        public async Task<bool> deleteAll()
        {
            if (Table != null)
                foreach (var item in Table)
                {
                    Table.Remove(item);
                }
            var AffectedRows = await Save();
            if (AffectedRows > 0) return true;
            return false;
        }
        public async Task<List<T>> GetAllAsync()
        {
            List<T> query =await Table.ToListAsync()/*.Where(b => !b.IsDeleted)*/;
            return query;
        }
        public async Task<T> GetById(int id)
        {
            if (id>=0)
            {
                return await Table.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
            }
            return null;
        }
        public async Task<int> Save()
        {
            var AfeectedRows = await _context.SaveChangesAsync();
            return AfeectedRows;
        }
        public async Task<T> Update(T entity)
        {
            Table.Update(entity);
            await Save();
            return entity;
        }
        public async Task<bool> Create(T entity)
        {
            await Table.AddAsync(entity);
            var AffectedRows = await Save();
            if (AffectedRows > 0) return true;
            return false;
        }
    }
}
