using Exam.Core.Models;
using Exam.Core.Repositories.Interfaces;
using Exam.Data.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(TEntity entity)
        {
             await Table.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            Table.Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
         return await  Table.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Table.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
