using Exam.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Core.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> 
        where TEntity : BaseEntity,
        new()
    {

        public DbSet<TEntity> Table { get; }
        Task CreateAsync(TEntity entity);       
        Task<int> CommitAsync();
        void Delete(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
       

    }
}
