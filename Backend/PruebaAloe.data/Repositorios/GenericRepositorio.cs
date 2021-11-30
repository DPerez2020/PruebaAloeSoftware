using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAloe.data.Repositorios
{
    public class GenericRepositorio<T>: IGenericRepository<T> where T:class
    {
        public ApplicationDBContext _applicationDbContext { get; set; }
        public GenericRepositorio(ApplicationDBContext applicationDbContext) {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<T> Create(T entity)
        {
            var result = await _applicationDbContext.Set<T>().AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<T> Get(int id)
        {
            var result = await _applicationDbContext.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var result = await _applicationDbContext.Set<T>().ToListAsync();
            return result;

        }

        public async Task<T> Update(T entity)
        {
            var result = _applicationDbContext.Set<T>().Update(entity);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

    }
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Create(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> Update(T entity);
        Task<T> Get(int id);        
    }
}
